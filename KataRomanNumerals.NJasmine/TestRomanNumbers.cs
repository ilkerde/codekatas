
namespace KataRomanNumbers
{
  using System.Collections.Generic;
  using NJasmine;

  public class RomanNumberSpecs : GivenWhenThenFixture
  {
    public override void Specify()
    {
      describe("single letter conversions", () => it_can_convert(new Dictionary<int, string>()
      {
        {1, "I"},
        {5, "V"},
        {10, "X"},
        {50, "L"},
        {100, "C"},
        {500, "D"},
        {1000, "M"}
      }));

      describe("additive values", () => it_can_convert(new Dictionary<int, string>()
      {
        {2, "II"},
        {7, "VII"}
      }));

      describe("substractive values", () => it_can_convert(new Dictionary<int, string>()
      {
        {4, "IV"},
        {9, "IX"},
        {40, "XL"},
        {90, "XC"},
        {400, "CD"},
        {900, "CM"},
      }));
    }

    private void it_can_convert(Dictionary<int, string> dictionary)
    {
      foreach (var scenario in dictionary)
      {
        it("should value " + scenario.Key + " with " + scenario.Value,
          () => { expect(() => scenario.Key.ToRoman() == scenario.Value); });
      }
    }
  }
}
