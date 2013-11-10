namespace Kata

import System
import System.Linq.Enumerable from System.Core

import Kata.Point

class TennisGame:
    public score as (Point)

    def constructor():
        score = (Love, Love)

    def constructor(player1 as Point, player2 as Point):
        score = (player1, player2)

    def scorePlayerOne():
        if isDeuce(score):
            return TennisGame(Advantage, score[1])

        return TennisGame(next(score[0]), score[1])

    def scorePlayerTwo():
        return TennisGame(score[0], next(score[1]))

    def next(point as Point):
        if point == Love:
            return Fifteen
        if point == Fifteen:
            return Thirty
        if point == Thirty:
            return Forty
        if point == Forty:
            return Game

        return Love

    def isDeuce(score as (Point)):
        return score.All({ p as Point | p == Forty })

