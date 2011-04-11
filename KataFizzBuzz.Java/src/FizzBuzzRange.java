import java.util.ArrayList;
import java.util.List;

public class FizzBuzzRange {
	private FizzBuzz _fizzbuzz;
	
	public FizzBuzzRange(FizzBuzz fizzbuzz) {
		_fizzbuzz = fizzbuzz;
	}

	public List<String> Range(int from, int to) {
		List<String> translations = new ArrayList<String>();
		
		for (int i=from; i<=to; i++)
			translations.add(_fizzbuzz.Translate(i));
		
		return translations;
	}
}
