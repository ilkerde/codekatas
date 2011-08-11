namespace KataRomanNumbers {
  using System;
  using NUnit.Framework;
  using NJasmine;

  public class RomanNumberSpecs : GivenWhenThenFixture {
    public override void Specify() {
      describe("single letter conversions", () => {
        it("should value 1 with I", () => {
          expect(() => 1.ToRoman() == "I");
        });

        it("should value 5 with V", () => {
          expect(() => 5.ToRoman() == "V");
        });
      });
    }
  }
}
