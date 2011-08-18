. .\roman_number.ps1

to_roman 1 | should be_equal "I"
to_roman 5 | should be_equal "V"
to_roman 10 | should be_equal "X"
to_roman 50 | should be_equal "L"
to_roman 100 | should be_equal "C"
