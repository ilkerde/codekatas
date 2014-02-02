module Ranger

open System

let rng lo hi = [lo..hi]
let has i s = s |> List.exists (fun x -> x = i)
