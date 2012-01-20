namespace Kata

open System
open System.Collections.Generic

type Translation = 
  {
    Source :int;
    Target :string
  }

module FizzBuzz =
  let translate number =
    let fizz = if number % 3 = 0 then "Fizz" else ""
    let buzz = if number % 5 = 0 then "Buzz" else ""

    let fizzbuzz = fizz + buzz
    let snumber = sprintf "%d" number

    if fizzbuzz = "" then snumber else fizzbuzz

  let translateRange start stop = 
    new List<Translation>(
      seq { 
        for number in start .. stop do 
        yield { Source = number; Target = translate number }
      }
    )
