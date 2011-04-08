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

	beforeEach(function() {
		fizzbuzz = FizzBuzz;
	});
});
