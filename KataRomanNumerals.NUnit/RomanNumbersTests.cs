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
  }
}
