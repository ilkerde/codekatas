module Tennis
open System

type Player = 
  | PlayerOne
  | PlayerTwo

type Point = 
  | Love
  | Fifteen
  | Thirty
  | Forty
  | Advantage
  | Win

let game = id 

let score player points =
  let p1, p2 = points

  let advance p = 
    match p with
    | Love -> Fifteen
    | Forty -> Win
    | _ -> p

  let deuce = 
    match player with
    | PlayerOne when p1 = Advantage -> (Win, Forty)
    | PlayerTwo when p2 = Advantage -> (Forty, Win)
    | _ -> (Forty, Forty)
 
  let straight = 
    match player with
    | PlayerOne -> (advance p1, p2)
    | PlayerTwo -> (p1, advance p2)

  match points with
  | (Forty, Forty)
  | (Advantage, _)
  | (_, Advantage) -> deuce
  | _ -> straight
  
let isover points = 
  match points with
  | (Win, _) -> true
  | (_, Win) -> true
  | _ -> false

