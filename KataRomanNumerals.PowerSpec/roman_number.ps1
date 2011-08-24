function to_roman($number) {
  $letter = @{
    1   = "I";
    5   = "V";
    10  = "X";
    50  = "L";
    100 = "C";
    500 = "D";
    1000 = "M";
  }

  $roman = "";

  while ($number -gt 0) {
    $letter.getenumerator()       | 
    sort -p "key" -desc           | 
    ?{ ($number / $_.key) -ge 1 } | 
    select -first 1               |
    %{ 
      $times = $number % $_.key;
      $number -= $_.key; 
      $roman += $_.value; 
    }
  }

  $roman = $roman.replace("IIII", "IV")
  $roman = $roman.replace("VIV", "IX")
  $roman = $roman.replace("XXXX", "XL")
  $roman = $roman.replace("LXL", "XC")
  $roman
}
