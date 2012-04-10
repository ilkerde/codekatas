root = exports ? this

add = (numbers) ->
  return 0 if numbers == "" or not numbers?
  parseInt numbers

root.add = add

