import static org.junit.Assert.*;
import org.junit.Test;

public class FizzBuzzTests {
	@Test
	public void multiples_of_three_translates_to_fizz() {
		FizzBuzz fizzbuzz = new FizzBuzz();
		String translation = fizzbuzz.Translate(6);
		assertEquals("fizz", translation);
	}
}
