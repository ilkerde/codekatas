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

        it("should value 10 with X", () => {
          expect(() => 10.ToRoman() == "X");
        });

        it("should value 50 with L", () => {
          expect(() => 50.ToRoman() == "L");
        });

        it("should value 100 with C", () => {
          expect(() => 100.ToRoman() == "C");
        });

        it("should value 500 with D", () => {
          expect(() => 500.ToRoman() == "D");
        });

        it("should value 1000 with M", () => {
          expect(() => 1000.ToRoman() == "M");
        });
      });

      describe("additive values", () => {
        it("should value 2 with II", () => {
          expect(() => 2.ToRoman() == "II");
        });

        it("should value 7 with VII", () => {
          expect(() => 7.ToRoman() == "VII");
        });
      });

      describe("substractive values", () => {
        it("should value 4 with IV", () => {
          expect(() => 4.ToRoman() == "IV");
        });

        it("should value 9 with IX", () => {
          expect(() => 9.ToRoman() == "IX");
        });

        it("should value 40 with XL", () => {
          expect(() => 40.ToRoman() == "XL");
        });

        it("should value 90 with XC", () => {
          expect(() => 90.ToRoman() == "XC");
        });

        it("should value 400 with CD", () => {
          expect(() => 400.ToRoman() == "CD");
        });
      });
    }
  }
}
