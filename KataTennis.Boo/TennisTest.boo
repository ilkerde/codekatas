namespace Kata
import NUnit.Framework
import Kata.Point

[TestFixture]
class Game_starts:
    [Test]
    def score_is_love_all():
        game = TennisGame()
        assert game.score == (Love, Love)

    [Test]
    def if_player_one_scores_then_fifteen_love():
        game = (
            TennisGame()
            .scorePlayerOne())

        assert game.score == (Fifteen, Love)

    [Test]
    def if_player_two_scores_then_love_fifteen():
        game = (
            TennisGame()
            .scorePlayerTwo())

        assert game.score == (Love, Fifteen)

    [Test]
    def if_player_two_scores_after_player_one_then_fifteen_all():
        game = (
            TennisGame()
            .scorePlayerOne()
            .scorePlayerTwo())

        assert game.score == (Fifteen, Fifteen)

[TestFixture]
class Game_is_at_fifteen_all:
    [Test]
    def if_player_one_scores_then_thirty_fifteen():
        game = (TennisGame(Fifteen, Fifteen)
            .scorePlayerOne()
        )

        assert game.score == (Thirty, Fifteen)

    [Test]
    def if_player_two_scores_then_fifteen_thirty():
        game = (TennisGame(Fifteen, Fifteen)
            .scorePlayerTwo()
        )

        assert game.score == (Fifteen, Thirty)

[TestFixture]
class Game_is_at_thirty_all:
    [Test]
    def if_player_one_scores_then_forty_thirty():
        game = (TennisGame(Thirty, Thirty)
            .scorePlayerOne()
        )

        assert game.score == (Forty, Thirty)

    [Test]
    def if_player_one_scores_then_thirty_forty():
        game = (TennisGame(Thirty, Thirty)
            .scorePlayerTwo()
        )

        assert game.score == (Thirty, Forty)

    [Test]
    def if_player_one_score_twice_then_game():
        game = (TennisGame(Thirty, Thirty)
            .scorePlayerOne()
            .scorePlayerOne()
        )

        assert game.score == (Game, Thirty)

[TestFixture]
class Game_is_at_forty_all:
    [Test]
    def if_player_one_scores_then_adv_player_one():
        game = (TennisGame(Forty, Forty)
            .scorePlayerOne()
        )

        assert game.score == (Advantage, Forty)

    [Test]
    def if_player_two_scores_then_adv_player_two():
        game = (TennisGame(Forty, Forty)
            .scorePlayerTwo()
        )

        assert game.score == (Forty, Advantage)

