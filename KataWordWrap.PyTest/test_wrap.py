from wrap import wrap_at

def test_wrap_when_marker_is_within_word():
  result = wrap_at("longword", 4)
  assert result == "long\nword"

def test_nowrap_when_word_is_shorter_than_marker():
  result = wrap_at("short", 8)
  assert result == "short"

def test_wrap_at_space_when_2_words_with_marker_on_2nd():
  result = wrap_at("first second", 8)
  assert result == "first\nsecond"

def test_wrap_twice_at_space_when_3_words_with_marker_on_2nd():
  result = wrap_at("this runs well", 7)
  assert result == "this\nruns\nwell"

