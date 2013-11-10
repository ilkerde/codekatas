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

    def constructor(player as Player, pointPlayer1 as Point, pointPlayer2 as Point):
        score = (pointPlayer1, pointPlayer2)
        if not player == One:
            Array.Reverse(score)

    def opponentOf(player as Player):
        if player == One:
            return Two
        return One

    def pointsOfPlayer(player as Player):
        return score[player cast int]

    def pointsOfOpponent(player as Player):
        return score[opponentOf(player) cast int]

    def scorePlayerOne():
        return scorePlayer(One)

    def scorePlayerTwo():
        return scorePlayer(Two)

    def scorePlayer(player as Player):
        if isDeuce(score):
            return Game(player, Advantage, pointsOfOpponent(player))

        if advantagePlayer(opponentOf(player)):
            return Game.all(Forty)

        return Game(player, next(pointsOfPlayer(player)), pointsOfOpponent(player))

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
