module TennisTests

open Tennis
open Xunit

[<Fact>]
let when_score_is_love_love_then_game_is_not_over () =
  Assert.False(
    game (Love, Love) |> isover
  )

[<Fact>]
let when_score_is_forty_love_and_player_one_scores_then_game_is_over () =
  Assert.True(
    game (Forty, Love)
      |> score PlayerOne
      |> isover
  )

[<Fact>]
let when_score_is_love_forty_and_player_two_scores_then_game_is_over () =
  Assert.True(
    game (Love, Forty)
      |> score PlayerTwo
      |> isover
  )

[<Fact>]
let when_score_is_thirty_love_and_player_one_scores_then_game_is_not_over () =
  Assert.False(
    game (Thirty, Love)
      |> score PlayerOne
      |> isover
  )

