def scal_add(expression):
  if len(expression) == 0:
    return 0

  parts = []
  lines = expression.splitlines()
  separator, lines = _read_separator(lines)

  for line in lines:
    parts.extend(line.split(separator))

  if '' in parts:
    return 0

  numbers = [int(part) for part in parts]
  _disallow_negative_numbers(numbers)

  result = sum(numbers)
  return result

def _read_separator(lines):
  separator = ','
  line = lines[0]
  if line.startswith('//'):
    separator = line[2]
    lines = lines[1:]

  return separator, lines

def _disallow_negative_numbers(numbers):
  negatives = [
    number for number in numbers 
    if number < 0
  ]

  if len(negatives) > 0:
    raise ValueError('Negatives not allowed: %s' % str(negatives))

