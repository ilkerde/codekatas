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
  }
}
