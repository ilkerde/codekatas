module Tennis
open System

type players = 
  | PlayerOne
  | PlayerTwo

type point = 
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
  | _ -> p

let score player points =
  let p1, p2 = points

  match player with
  | PlayerOne -> (nextpoint p1, p2)
  | PlayerTwo -> (p1, nextpoint p2)
  
let isover points = 
  match points with
  | (Win, _) -> true
  | (_, Win) -> true
  | _ -> false

