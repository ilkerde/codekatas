namespace Kata
import NUnit.Framework

[TestFixture]
class TennisTest:

    [Test]
    def game_start_love_all():
        game = TennisGame()
        assert game.score() == (Love, Love)

