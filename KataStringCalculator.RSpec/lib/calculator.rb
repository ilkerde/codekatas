def convert_to_numbers parts
  parts.map {|x| x.to_i }
end

def sum_of numbers
  numbers.reduce {|s,n| s+n}
end

def remove_delimiter_definition_of numbers
  numbers.gsub! /^\/\/.+?\n/, '' 
end

def parse_delimiter_definition numbers
  return *(/^\/\/(.+)?\n.+/.match numbers)
end

class Calculator
  def self.add numbers
    return 0 if numbers == ""

    match, delimiter = parse_delimiter_definition numbers
    delimiters = Regexp.new "[#{delimiter},\n]"
    remove_delimiter_definition_of numbers unless match.nil?

    parts = numbers.split delimiters
    nums = convert_to_numbers parts

    negatives = nums.select {|x| x < 0}
    raise "Negatives not allowed. #{negatives.join ','}" unless negatives.empty?

    sum_of nums
  end
end
