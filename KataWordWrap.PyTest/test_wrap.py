from wrap import wrap_at

def test_wrap_when_marker_is_within_word():
  result = wrap_at("longword", 4)
  assert result == "long\nword"

def test_nowrap_when_word_is_shorter_than_marker():
  result = wrap_at("short", 8)
  assert result == "short"

