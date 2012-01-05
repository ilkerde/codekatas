from scal import scal_add

class test_when_single_number_is_given:
  def test_then_returns_same_number(self):
    assert scal_add("1") == 1
