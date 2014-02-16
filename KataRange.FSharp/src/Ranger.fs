module Ranger

open System

let rng lo hi = 
    [lo..hi]

let has i s = 
    s |> List.exists (fun x -> x = i)

let intersect s1 s2 = 
    Set.intersect (set s1) (set s2) |> Set.toList
