class Calculator
  def self.add numbers
    return 0 if numbers == ""

    parts = numbers.split /[,\n]+/
    nums = parts.map {|x| x.to_i }

    nums.reduce {|s,n| s+n}
  end
end
