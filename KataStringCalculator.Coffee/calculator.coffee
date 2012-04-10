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
  ints = (parseInt(part) for part in parts)
  negs = (i for i in ints when i < 0)

  throw new RangeError(negs.join()) if negs.length > 0

  sum = 0
  sum += i for i in ints
  sum

root.add = add

