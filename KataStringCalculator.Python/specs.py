from scal import scal_add

class test_when_single_number_is_given:
  def test_then_returns_same_number(self):
    assert scal_add("1") == 1

class test_when_two_numbers_separated_by_comma_are_given:
  def test_then_returns_sum_of_numbers(self):
    assert scal_add("3,5") == 8
