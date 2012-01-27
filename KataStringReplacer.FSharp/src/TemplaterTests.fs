module TemplaterTests

open Templater
open Xunit

[<Fact>]
let should_yield_empty_text_when_empty_text_is_provided () = 
  let text = subst "" []
  Assert.Equal<string>("", text)


[<Fact>]
let should_yield_text_when_text_is_passed_with_no_keywords () = 
  let text = subst "something" []
  Assert.Equal<string>("something", text)
