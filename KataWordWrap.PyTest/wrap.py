def wrap_at(text, marker):
  if len(text) < marker:
    return text

  return text[:marker] + '\n' + text[marker:]
