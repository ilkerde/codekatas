. .\roman_number.ps1

to_roman 1 | should be_equal "I"
to_roman 5 | should be_equal "V"
to_roman 10 | should be_equal "X"
to_roman 50 | should be_equal "L"
to_roman 100 | should be_equal "C"
to_roman 500 | should be_equal "D"
to_roman 1000 | should be_equal "M"

to_roman 2 | should be_equal "II"

to_roman 4 | should be_equal "IV"
to_roman 9 | should be_equal "IX"

to_roman 20 | should be_equal "XX"

to_roman 40 | should be_equal "XL"
to_roman 90 | should be_equal "XC"

to_roman 400 | should be_equal "CD"
to_roman 900 | should be_equal "CM"
