describe("FizzBuzz Translation", function() {
	var fizzbuzz;

	it("should translate multiples of three to 'Fizz'", function() {
		var translation = fizzbuzz.translate(6);
		expect(translation).toEqual("Fizz");
	});

	it("should translate multiples of five to 'Buzz'", function() {
		var translation = fizzbuzz.translate(10);
		expect(translation).toEqual("Buzz");
	});

	it("should translate multiples of three and five to 'FizzBuzz'", function() {
		var translation = fizzbuzz.translate(15);
		expect(translation).toEqual("FizzBuzz");
	});

	beforeEach(function() {
		fizzbuzz = FizzBuzz;
	});
});
