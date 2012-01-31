module Templater

open System

let subst (text:string) (values:(string * string) list) = 
  let createKey = sprintf "$%s$"

  let replaceSet (text:string) (set:string * string) =
    let k,v = set
    text.Replace(createKey k,v)

  values
  |> List.fold replaceSet text

