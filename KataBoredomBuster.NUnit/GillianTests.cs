namespace Kata {
  using System;
  using NUnit.Framework;

  [TestFixture] 
  public class When_number_is_divisible_by_2 {
    [TestCase(2, 1, 1)]
    [TestCase(4, 2, 2)]
    public void Then_returns_X_and_Y_as_number_divided_by_2(int number, int expectedX, int expectedY) {
      var split = Gillian.Split(number);
      split.ShouldSplitTo(expectedX, expectedY);
    }
  }

  [TestFixture]
  public class When_number_is_divisible_by_3 {
    [TestCase(3, 1, 2)]
    [TestCase(9, 3, 6)]
    public void Then_returns_X_as_one_third_of_number_and_Y_as_remainder(int number, int expectedX, int expectedY) {
      var split = Gillian.Split(9);
      split.ShouldSplitTo(3, 6);
    }
  }

  [TestFixture]
  public class When_number_is_1 {
    [Test]
    public void Then_does_not_split() {
      Assert.That(() => Gillian.Split(1), Throws.TypeOf<ArgumentException>());
    }
  }

  [TestFixture]
  public class When_number_is_not_divisible_by_2_or_3 {
    [TestCase(5, 1, 4)]
    [TestCase(11, 1, 10)]
    public void Then_returns_X_as_1_and_Y_as_remainder(int number, int expectedX, int expectedY) {
      var split = Gillian.Split(number);
      split.ShouldSplitTo(expectedX, expectedY);
    }
  }

  [TestFixture]
  public class When_number_is_divisible_by_2_and_3 {
    [Test]
    public void Then_returns_X_and_Y_as_number_divided_by_2() {
      var split = Gillian.Split(12);
      split.ShouldSplitTo(6, 6);
    }
  }

  [TestFixture]
  public class When_number_to_split_is_4 {
    [Test]
    public void Then_gillian_should_split_the_number() {
      var fake = new Fake();
      var game = new Game(fake.Split);
      game.Go(4);
      Assert.IsTrue(fake.WasCalled);
    }

    [Test]
    public void Then_gillian_should_split_4() {
      var fake = new Fake();
      var game = new Game(fake.Split);
      game.Go(4);
      Assert.That(fake.CalledNumber, Is.EqualTo(4));
    }

    [TestCase(9, 9, 81)]
    [TestCase(5, 7, 35)]
    public void Then_returns_the_product_of_the_split_returned_by_gillian(int x, int y, int expectedProduct) {
      var fake = new Fake(new SplitPair { X=x, Y=y });
      var game = new Game(fake.Split);
      Assert.That(game.Go(2), Is.EqualTo(expectedProduct));
    }
  }

  [TestFixture]
  public class When_a_split_returns_X_with_a_number_higher_than_1 {
    Fake _fake;

    [SetUp]
    public void Given_that_a_split_with_a_number_higher_than_2_was_done_before() {
      _fake = new Fake(new SplitPair { X=2, Y=1 });
      var game = new Game(_fake.Split);
      game.Go(3);
    }

    [Test]
    public void Then_the_split_is_called_again() {
      Assert.That(_fake.NumberOfCalls, Is.EqualTo(2));
    }

    [Test]
    public void Then_the_second_split_is_done_with_X_of_previous_split() {
      Assert.That(_fake.CalledNumber, Is.EqualTo(2));
    }
  }

  public class Fake {
    SplitPair _splitToReturn = new SplitPair();
    
    public Fake() {}

    public Fake(SplitPair splitToReturn) {
      _splitToReturn = splitToReturn;
    }

    public bool WasCalled { get; set; }
    public int NumberOfCalls { get; set; }
    public int CalledNumber { get; set; }
    
    public SplitPair Split(int number) {
      NumberOfCalls++;
      CalledNumber = number;
      WasCalled = true;
      return _splitToReturn;
    }
  }

  public static class ShouldExtensions {
    public static void ShouldSplitTo(this SplitPair pair, int x, int y) {
      Assert.AreEqual(x, pair.X);
      Assert.AreEqual(y, pair.Y);
    }
  }
}
