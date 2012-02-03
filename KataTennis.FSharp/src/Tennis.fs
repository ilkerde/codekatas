module Tennis
open System

type players = 
  | PlayerOne
  | PlayerTwo

type scores = 
  | Love
  | Fifteen
  | Thirty
  | Forty
  | Advantage
  | Win

let game (score:scores * scores) = score
let score player = game
let isover game = false
