module RangerTests

open Ranger
open Xunit

[<Fact>]
let ``when range starts with 1 and ends with 3`` () =
    Assert.Equal (3, rng 1 3 |> List.length)

