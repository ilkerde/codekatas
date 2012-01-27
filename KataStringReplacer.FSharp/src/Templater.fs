module Templater

open System

let subst (text:string) (values:(string * string) list) = 
  text
