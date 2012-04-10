root = exports ? this

add = (numbers) ->
  return 0 if numbers == "" or not numbers?

  regex = new RegExp  /[\s,]+/

  if numbers.search(/^\/\//) >= 0
    newline = numbers.indexOf '\n'
    separator = numbers.substring(2, newline)
    numbers = numbers.substring(newline + 1)
    regex = new RegExp "[\\s,#{separator}]+"

  parts = numbers.split regex

  sum = 0
  sum += parseInt part for part in parts

  sum

root.add = add

