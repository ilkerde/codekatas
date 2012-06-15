class Calculator
  def self.add numbers
    return 0 if numbers == ""

    match, delimiter = *(/^\/\/(.+)?\n.+/.match numbers)
    delimiters = Regexp.new "[#{delimiter},\n]"
    numbers.gsub! /^\/\/.+?\n/, '' unless match.nil?

    parts = numbers.split delimiters
    nums = parts.map {|x| x.to_i }

    negatives = nums.select {|x| x < 0}
    raise "Negatives not allowed." unless negatives.empty?

    nums.reduce {|s,n| s+n}
  end
end
