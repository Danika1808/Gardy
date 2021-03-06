namespace DomainModels

open System.ComponentModel.DataAnnotations
open System.Text.Json
 
[<CLIMutable>]
[<NoComparison; NoEquality>]
type Property =
    {
        [<Key>]
        Id:int
        Name:string
        Type:PropertyType

        
        Constraints:JsonDocument
        FilterInfo:JsonDocument
    }