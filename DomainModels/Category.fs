namespace DomainModels

open System.Collections.Generic;
open System.ComponentModel.DataAnnotations

[<CLIMutable>]
[<NoComparison; NoEquality>]
type Category =
    {
        [<Key>]
        Id:int
        Name:string
        
        Properties:ICollection<Property>
    }