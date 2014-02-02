module RangerTests

open Ranger
open Xunit

[<Fact>]
let ``when range starts with 1 and ends with 3`` () =
    Assert.Equal (3, rng 1 3 |> List.length)

[<Fact>]
let ``2 is in range of 1..3`` () =
    Assert.True ([1..3] |> has 2)

[<Fact>]
let ``4 is not in range of 1..3`` () =
    Assert.False ([1..3] |> has 4)

