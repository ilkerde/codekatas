module Templater

open System

let subst (text:string) (values:(string * string) list) = 
  let firstSet (values:(string*string) list) =
    match values with
    | head::tail -> head
    | [] -> ("any","any")

  let createKey = sprintf "$%s$"

  let replaceSet (text:string) (set:string * string) =
    let k,v = set
    text.Replace(createKey k,v)

  replaceSet text (firstSet values)


