class FizzBuzz
	def translate(number)
		if number % 15 == 0
			return "fizzbuzz"
		end

		if number % 5 == 0
			return "buzz"
		end

		if number % 3 == 0
			return "fizz"
		end

		return number.to_s
	end

	def translate_all(start, stop)
		(start..stop).collect do |number|
			translate number
		end
	end
end

