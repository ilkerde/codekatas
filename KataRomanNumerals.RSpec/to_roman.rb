class Fixnum
  def to_roman 
    romans = { 
      1 => "I", 
      5 => "V", 
      10 => "X"
    }
    
    romans[self]
  end
end
