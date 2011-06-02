namespace vala.fizzbuzz {
  public class FizzBuzz {
    public FizzBuzz() {}

    public string translate(int number) {
      if (number % 15 == 0)
        return "FizzBuzz";

      if (number % 5 == 0)
        return "Buzz";

      return "Fizz";
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

    Test.run();
  }
}
