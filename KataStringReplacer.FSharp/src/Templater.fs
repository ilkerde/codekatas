module Templater

open System

let subst (text:string) (values:(string * string) list) = 
  let createKey = sprintf "$%s$"

  let replaceSet (text:string) (set:string * string) =
    let k,v = set
    text.Replace(createKey k,v)

  let (|AnyKey|_|) (text:string) = 
    let lpos = text.IndexOf("$")
    if lpos < 0 then
      None
    else
      let rpos = text.IndexOf("$", lpos + 1)
      if rpos > lpos then
        Some (text.Substring(lpos, rpos - lpos + 1))
      else
        None

  let rec wipeKeys (text:string) = 
    match text with
    | AnyKey(k) -> wipeKeys (text.Replace(k, ""))
    | _ -> text

  let newText = 
    values
    |> List.fold replaceSet text

  wipeKeys newText
