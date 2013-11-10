namespace Kata

import System
import System.Linq.Enumerable from System.Core

import Kata.Point
import Kata.Player

class Game:
    public score as (Point)

    static def start():
        return Game(Love, Love)

    static def at(player1 as Point, player2 as Point):
        return Game(player1, player2)

    static def all(point as Point):
        return Game(point, point)

    def constructor(player1 as Point, player2 as Point):
        score = (player1, player2)

    def scorePlayerOne():
        if isDeuce(score):
            return Game(Advantage, score[1])

        if advantagePlayer(Two):
            return Game(Forty, Forty)

        return Game(next(score[0]), score[1])

    def scorePlayerTwo():
        if isDeuce(score):
            return Game(score[0], Advantage)

        if advantagePlayer(One):
            return Game(Forty, Forty)

        return Game(score[0], next(score[1]))

    def next(point as Point):
        if point == Love:
            return Fifteen
        if point == Fifteen:
            return Thirty
        if point == Thirty:
            return Forty
        if point == Forty:
            return Win
        if point == Advantage:
            return Win

        return Love

    def isDeuce(score as (Point)):
        return score.All({ p as Point | p == Forty })

    def advantagePlayer(player as Player):
        return score[player cast int] == Advantage
