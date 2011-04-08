describe("FizzBuzz Translation", function() {
	var fizzbuzz;

	it("should translate multiples of three to 'Fizz'", function() {
		var translation = fizzbuzz.translate(6);
		expect(translation).toEqual("Fizz");
	});

	beforeEach(function() {
		fizzbuzz = FizzBuzz;
	});
});
