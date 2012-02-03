module TennisTests

open Tennis
open Xunit

[<Fact>]
let when_score_is_love_love_then_game_is_not_over () =
  Assert.False(
    game |> isover
  )

