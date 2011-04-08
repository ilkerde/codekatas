var FizzBuzz = {
	translate: function(number) {
		if (number % 15 == 0)
			return "FizzBuzz";

		if (number % 5 == 0)
			return "Buzz";

		if (number % 3 == 0)
			return "Fizz";

		return number.toString();
	},
	
    translateRange: function(from, to) {
		var translations = [];
		for(var i=from; i<to; i++)
			translations[i] = null;

		return translations;
	}
};
