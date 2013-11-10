namespace Kata

import NUnit.Framework

import Kata.Point
import Kata.Game

[TestFixture]
class Game_starts:
    [Test]
    def score_is_love_all():
        game = Game.start()
        assert game.score == (Love, Love)

    [Test]
    def if_player_one_scores_then_fifteen_love():
        game = (Game
            .start()
            .scorePlayerOne())

        assert game.score == (Fifteen, Love)

    [Test]
    def if_player_two_scores_then_love_fifteen():
        game = (Game
            .start()
            .scorePlayerTwo())

        assert game.score == (Love, Fifteen)

    [Test]
    def if_player_two_scores_after_player_one_then_fifteen_all():
        game = (Game
            .start()
            .scorePlayerOne()
            .scorePlayerTwo())

        assert game.score == (Fifteen, Fifteen)

[TestFixture]
class Game_is_at_fifteen_all:
    [Test]
    def if_player_one_scores_then_thirty_fifteen():
        game = (Game
            .all(Fifteen)
            .scorePlayerOne())

        assert game.score == (Thirty, Fifteen)

    [Test]
    def if_player_two_scores_then_fifteen_thirty():
        game = (Game
            .all(Fifteen)
            .scorePlayerTwo())

        assert game.score == (Fifteen, Thirty)

[TestFixture]
class Game_is_at_thirty_all:
    [Test]
    def if_player_one_scores_then_forty_thirty():
        game = (Game
            .all(Thirty)
            .scorePlayerOne())

        assert game.score == (Forty, Thirty)

    [Test]
    def if_player_one_scores_then_thirty_forty():
        game = (Game
            .all(Thirty)
            .scorePlayerTwo())

        assert game.score == (Thirty, Forty)

    [Test]
    def if_player_one_score_twice_then_game():
        game = (Game
            .all(Thirty)
            .scorePlayerOne()
            .scorePlayerOne())

        assert game.score == (Win, Thirty)

    [Test]
    def if_player_two_score_twice_then_game():
        game = (Game
            .all(Thirty)
            .scorePlayerTwo()
            .scorePlayerTwo())

        assert game.score == (Thirty, Win)

[TestFixture]
class Game_is_at_forty_all:
    [Test]
    def if_player_one_scores_then_adv_player_one():
        game = (Game
            .all(Forty)
            .scorePlayerOne())

        assert game.score == (Advantage, Forty)

    [Test]
    def if_player_two_scores_then_adv_player_two():
        game = (Game
            .all(Forty)
            .scorePlayerTwo())

        assert game.score == (Forty, Advantage)

    [Test]
    def if_player_one_scores_and_player_two_scores_then_forty_all():
        game = (Game
            .all(Forty)
            .scorePlayerOne()
            .scorePlayerTwo())

        assert game.score == (Forty, Forty)

    [Test]
    def if_player_two_scores_and_player_one_scores_then_forty_all():
        game = (Game
            .all(Forty)
            .scorePlayerTwo()
            .scorePlayerOne())

        assert game.score == (Forty, Forty)

    [Test]
    def if_player_one_scores_twice_then_game():
        game = (Game
            .all(Forty)
            .scorePlayerOne()
            .scorePlayerOne())

        assert game.score == (Win, Forty)

    [Test]
    def if_player_two_scores_twice_then_game():
        game = (Game
            .all(Forty)
            .scorePlayerTwo()
            .scorePlayerTwo())

        assert game.score == (Forty, Win)
