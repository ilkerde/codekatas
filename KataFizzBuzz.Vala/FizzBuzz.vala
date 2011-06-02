namespace vala.fizzbuzz {
  using Gee;

  public class FizzBuzz {
    public FizzBuzz() {}

    public string translate(int number) {
      if (number % 15 == 0)
        return "FizzBuzz";

      if (number % 5 == 0)
        return "Buzz";

      if (number % 3 == 0)
        return "Fizz";

      return number.to_string();
    }

    public HashMap<int,string> translate_range(int from, int to) {
      var map = new HashMap<int,string>();

      for (int i=from; i<=to; i++) 
        map.set(i, "");

      return map;
    }
  }

  public static void main(string[] args) {
    if ("test" in args) test(args);
  }

  public static void test(string[] args) {
    Test.init(ref args);

    Test.add_func("/ fizzbuzz / when number is multiples of three / then returns fizz", () => {
      var fizzbuzz = new FizzBuzz();
      var translation = fizzbuzz.translate(6);
      assert(translation == "Fizz");
    });

    Test.add_func("/ fizzbuzz / when number is multiples of five / then returns buzz", () => {
      var fizzbuzz = new FizzBuzz();
      var translation = fizzbuzz.translate(10);
      assert(translation == "Buzz");
    });

    Test.add_func("/ fizzbuzz / when number is multiples of five and three / then returns fizzbuzz", () => {
      var fizzbuzz = new FizzBuzz();
      var translation = fizzbuzz.translate(15);
      assert(translation == "FizzBuzz");
    });

    Test.add_func("/ fizzbuzz / when number is no multiples of five or three / then returns number", () => {
      var fizzbuzz = new FizzBuzz();
      var translation = fizzbuzz.translate(7);
      assert(translation == "7");
    });

    Test.add_func("/ fizzbuzz / when tranlating numbers in range from 1 to 100 / then returns array of 100 entries", () => {
      var fizzbuzz = new FizzBuzz();
      var translations = fizzbuzz.translate_range(1, 100);
      assert(translations.size == 100);
    });

    Test.add_func("/ fizzbuzz / when translating number by range / then returns translation through translate()", () => {
      var fizzbuzz = new FizzBuzz();
      var translations = fizzbuzz.translate_range(1, 15);

      foreach (var entry in translations.entries)
        assert(entry.value == fizzbuzz.translate(entry.key));
    });

    Test.run();
  }
}
