class Fixnum
  def to_roman 
    romans = { 
      1 => "I", 
      4 => "IV",
      5 => "V", 
      9 => "IX",
      10 => "X",
      50 => "L"
    }
    
    roman = ""
    value = self

    romans.keys.sort.reverse.each do |dec|
      while value >= dec
        roman << romans[dec]
        value -= dec
      end
    end

    roman
  end
end
