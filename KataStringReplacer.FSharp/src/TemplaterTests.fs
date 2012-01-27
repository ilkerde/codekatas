module TemplaterTests

open Templater
open Xunit

[<Fact>]
let should_yield_empty_text_when_empty_text_is_provided () = 
  let text = subst "" []
  Assert.Equal<string>("", text)


