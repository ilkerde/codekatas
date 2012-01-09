def scal_add(expression):
  if len(expression) == 0:
    return 0

  parts = []
  lines = expression.splitlines()

  for line in lines:
    parts.extend(line.split(','))

  numbers = [int(part) for part in parts]

  result = sum(numbers)
  return result

