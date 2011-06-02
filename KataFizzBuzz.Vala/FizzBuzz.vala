namespace vala.fizzbuzz {
  public class FizzBuzz {
    public FizzBuzz() {}

    public string translate(int number) {
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

    Test.run();
  }
}
