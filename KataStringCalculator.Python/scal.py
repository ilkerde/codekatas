def scal_add(expression):
  parts = expression.split(',')
  numbers = [int(part) for part in parts]
  result = sum(numbers)
  return result

