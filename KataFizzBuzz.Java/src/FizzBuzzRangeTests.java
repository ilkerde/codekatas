import static org.junit.Assert.*;
import static org.mockito.Mockito.*;

import java.util.List;
import org.junit.Test;

public class FizzBuzzRangeTests {
	@Test
	public void Range_From_1_to_100_Gives_100_Entries()
	{
		FizzBuzzRange fizzbuzzrange = new FizzBuzzRange(mock(FizzBuzz.class));
		List<String> translations = fizzbuzzrange.Range(1, 100);
		assertEquals(100, translations.size());
	}
	
	@Test
	public void Range_Translates_Entries()
	{
		FizzBuzz fizzbuzz = mock(FizzBuzz.class);
		when(fizzbuzz.Translate(anyInt())).thenReturn("fake");
		
		FizzBuzzRange fizzbuzzrange = new FizzBuzzRange(fizzbuzz);
		List<String> translations = fizzbuzzrange.Range(1, 10);
		
		for (int i=1; i<=10; i++)
			verify(fizzbuzz).Translate(i);
	}
}
