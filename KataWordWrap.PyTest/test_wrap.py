from wrap import wrap_at

def test_wrap_when_marker_is_within_word():
  result = wrap_at("longword", 4)
  assert result == "long\nword"

