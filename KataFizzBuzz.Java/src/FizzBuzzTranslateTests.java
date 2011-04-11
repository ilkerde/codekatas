import static org.junit.Assert.*;
import org.junit.Test;

public class FizzBuzzTranslateTests {
	@Test
	public void multiples_of_three_translates_to_fizz() {
		FizzBuzz fizzbuzz = new FizzBuzz();
		String translation = fizzbuzz.Translate(6);
		assertEquals("fizz", translation);
	}

	@Test
	public void multiples_of_five_translates_to_buzz() {
		FizzBuzz fizzbuzz = new FizzBuzz();
		String translation = fizzbuzz.Translate(10);
		assertEquals("buzz", translation);
	}

	@Test
	public void multiples_of_three_and_five_translates_to_fizzbuzz() {
		FizzBuzz fizzbuzz = new FizzBuzz();
		String translation = fizzbuzz.Translate(15);
		assertEquals("fizzbuzz", translation);
	}
	
	@Test
	public void no_multiples_of_three_or_five_translates_to_number() {
		FizzBuzz fizzbuzz = new FizzBuzz();
		String translation = fizzbuzz.Translate(7);
		assertEquals("7", translation);
	}
}
