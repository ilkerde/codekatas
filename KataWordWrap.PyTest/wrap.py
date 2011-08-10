def wrap_at(text, marker):
  if len(text) < marker:
    return text

  lastspace = text[:marker].rfind(' ')
  cutoff = lastspace if lastspace > 0 else marker

  return text[:cutoff].strip() + '\n' + text[cutoff:].strip()
