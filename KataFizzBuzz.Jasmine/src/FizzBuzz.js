var FizzBuzz = {
	translate: function(number) {
		if (number % 15 == 0)
			return "FizzBuzz";

		if (number % 5 == 0)
			return "Buzz";

		return "Fizz";
	}
};
