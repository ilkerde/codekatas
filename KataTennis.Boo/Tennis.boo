namespace Kata
import System
import Kata.Point

class TennisGame:
    public score as (Point)

    def constructor():
        score = (Love, Love)

    def constructor(player1 as Point, player2 as Point):
        score = (player1, player2)

    def scorePlayerOne():
        return TennisGame(Fifteen, Love)

    def scorePlayerTwo():
        return TennisGame(Love, Fifteen)


