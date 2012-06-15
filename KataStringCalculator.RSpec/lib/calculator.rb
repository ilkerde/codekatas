class Calculator
  def self.add numbers
    return 0 if numbers == ""

    match, delimiter = *(/^\/\/(.+)?\n.+/.match numbers)
    delimiters = Regexp.new "[#{delimiter},\n]"
    numbers.gsub! /^\/\/.+?\n/, '' unless match.nil?

    parts = numbers.split delimiters
    nums = parts.map {|x| x.to_i }

    nums.reduce {|s,n| s+n}
  end
end
