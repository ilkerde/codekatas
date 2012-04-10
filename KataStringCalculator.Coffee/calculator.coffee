root = exports ? this

add = (numbers) ->
  return 0 if numbers == "" or not numbers?
  parts = numbers.split /[\s,]+/

  sum = 0
  sum += parseInt part for part in parts

  sum

root.add = add

