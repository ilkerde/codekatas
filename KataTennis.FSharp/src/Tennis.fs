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

let game = id 

let nextpoint p = 
  match p with
  | Forty -> Win
  | _____ -> p

let score player currentscore =
  let p1, p2 = currentscore

  match player with
  | PlayerOne -> (nextpoint p1, p2)
  | PlayerTwo -> currentscore
  
let isover (currentscore:scores * scores) = 
  match currentscore with
  | (Win, _) -> true
  | ________ -> false

