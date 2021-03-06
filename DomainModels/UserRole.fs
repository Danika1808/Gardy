namespace DomainModels

open System.ComponentModel.DataAnnotations

type UserRoleEnum =
    | Normal = 0
    | Admin = 1    

[<CLIMutable>]
[<NoComparison; NoEquality>]
type UserRole =
    {
        [<Key>]
        Id:int
        Name:string
    }