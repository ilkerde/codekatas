import static org.junit.Assert.*;

import java.util.List;
import org.junit.Test;

public class FizzBuzzRangeTests {
	@Test
	public void Range_From_1_to_100_Gives_100_Entries()
	{
		FizzBuzzRange fizzbuzzrange = new FizzBuzzRange();
		List<String> translations = fizzbuzzrange.Range(1, 100);
		assertEquals(100, translations.size());
	}
}
