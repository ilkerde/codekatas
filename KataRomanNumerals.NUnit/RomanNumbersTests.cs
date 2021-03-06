namespace RomanNumbers {
  using System;
  using NUnit.Framework;

  [TestFixture]
  public class ToRomanTests {
    [Test]
    public void when_number_is_1_then_converts_to_I() {
      Assert.That(1.ToRoman(), Is.EqualTo("I"));
    }

    [Test]
    public void when_number_is_2_then_converts_to_II() {
      Assert.That(2.ToRoman(), Is.EqualTo("II"));
    }

    [Test]
    public void when_number_is_4_then_converts_to_IV() {
      Assert.That(4.ToRoman(), Is.EqualTo("IV"));
    }

    [Test]
    public void when_number_is_5_then_converts_to_V() {
      Assert.That(5.ToRoman(), Is.EqualTo("V"));
    }

    [Test]
    public void when_number_is_9_then_converts_to_IX() {
      Assert.That(9.ToRoman(), Is.EqualTo("IX"));
    }

    [Test]
    public void when_number_is_10_then_converts_to_X() {
      Assert.That(10.ToRoman(), Is.EqualTo("X"));
    }

    [Test]
    public void when_number_is_40_then_converts_to_XL() {
      Assert.That(40.ToRoman(), Is.EqualTo("XL"));
    }

    [Test]
    public void when_number_is_50_then_converts_to_L() {
      Assert.That(50.ToRoman(), Is.EqualTo("L"));
    }

    [Test]
    public void when_number_is_90_then_converts_to_XC() {
      Assert.That(90.ToRoman(), Is.EqualTo("XC"));
    }

    [Test]
    public void when_number_is_100_then_converts_to_C() {
      Assert.That(100.ToRoman(), Is.EqualTo("C"));
    }

    [Test]
    public void when_number_is_400_then_converts_to_CD() {
      Assert.That(400.ToRoman(), Is.EqualTo("CD"));
    }

    [Test]
    public void when_number_is_500_then_converts_to_D() {
      Assert.That(500.ToRoman(), Is.EqualTo("D"));
    }

    [Test]
    public void when_number_is_900_then_converts_to_CM() {
      Assert.That(900.ToRoman(), Is.EqualTo("CM"));
    }

    [Test]
    public void when_number_is_1000_then_converts_to_M() {
      Assert.That(1000.ToRoman(), Is.EqualTo("M"));
    }

    [Test]
    public void when_number_is_1999_then_converts_to_MCMXCIX() {
      Assert.That(1999.ToRoman(), Is.EqualTo("MCMXCIX"));
    }
  }
}
