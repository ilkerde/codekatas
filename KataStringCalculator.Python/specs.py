from scal import scal_add

class test_when_nothing_is_given:
  def test_then_returns_zero(self):
    assert scal_add("") == 0

class test_when_single_number_is_given:
  def test_then_returns_same_number(self):
    assert scal_add("1") == 1

class test_when_two_numbers_separated_by_comma_are_given:
  def test_then_returns_sum_of_numbers(self):
    assert scal_add("3,5") == 8

class test_when_arbitrary_number_of_numbers_are_given:
  def test_then_returns_sum_of_numbers(self):
    assert scal_add("3,5,8,13,21") == 50

class test_when_numbers_are_separated_by_newline_are_given:
  def test_then_returns_sum_of_numbers(self):
    assert scal_add("3\n5") == 8

class test_when_numbers_are_separated_by_newline_and_comma_are_given:
  def test_then_returns_sum_of_numbers(self):
    assert scal_add("3\n5,8") == 16

class test_when_no_number_is_between_separators:
  def test_then_returns_zero(self):
    assert scal_add("3,") == 0

