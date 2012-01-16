from unittest import TestCase
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

class test_when_first_line_starts_with_doubleslash:
  def test_then_the_char_afterwards_is_a_delimiter(self):
    assert scal_add("//:\n2:2") == 4

class test_when_negative_number_is_given(TestCase):
  def test_then_raises_error(self):
    self.assertRaises(ValueError, lambda: scal_add("-2,2"))

  def test_then_includes_negatives_in_error_message(self):
    self.assertRaisesRegexp(ValueError, '.*-2.*-4.*', lambda: scal_add("-2,-4"))

