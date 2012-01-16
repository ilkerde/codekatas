def scal_add(expression):
  if len(expression) == 0:
    return 0

  parts = []
  lines = expression.splitlines()

  separator = ','

  firstline = lines[0]
  if firstline.startswith('//'):
    separator = firstline[2]
    lines = lines[1:]

  for line in lines:
    parts.extend(line.split(separator))

  if '' in parts:
    return 0

  numbers = [int(part) for part in parts]

  result = sum(numbers)
  return result

