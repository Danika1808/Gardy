using DomainModels;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace WebShop_NULL
{
    public static class JsonDocumentExtensions
    {
        public static string ToJsonString(this JsonDocument jdoc)
        {
            using (var stream = new MemoryStream())
            {
                Utf8JsonWriter writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
                jdoc.WriteTo(writer);
                writer.Flush();
                return Encoding.UTF8.GetString(stream.ToArray());
            }
        }

        public class IdValue 
        { 
            public string Id { get; set; }
            public string Value { get; set; }
        }

        public static List<IdValue> GetPropertyValues(this JsonDocument jDoc)
        {
            var dict = JsonSerializer.Deserialize<Dictionary<string, object>>(jDoc.ToJsonString())
                .ToDictionary(pair => pair.Key.ToString(), pair => pair.Value.ToString());

            var result = new List<IdValue>();

            foreach (var item in dict)
            {
                result.Add(new IdValue { Id = item.Key, Value = item.Value });
            }

            return result;
        }
    }
}