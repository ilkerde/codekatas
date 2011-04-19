using System;
using System.Collections.Generic;

using Machine.Specifications;

namespace KataPickAkin {
	public class PickAkinSpecs {
		public class when_left_contains_one_akin_product_of_right {
			It should_have_both_product_code_in_akin_list = 
				() => result.AkinList.ShouldContain(new [] {"A1", "A2"});

			It should_have_empty_left = 
				() => result.LeftCodeList.ShouldBeEmpty();

			It should_have_empty_right = 
				() => result.RightCodeList.ShouldBeEmpty();

			Because of =
				() => result = new PickAkin(left, right).Pick();

			Establish context =
				() => {
					left = new List<string> { "A1" };
					right = new List<string> { "A2" };
				};

			static List<string> left, right;
			static PickAkinResult result;
		}

		public class when_left_contains_no_akin_product_of_right {
			It should_have_no_akin =
				() => result.AkinList.ShouldBeEmpty();

			It should_have_left_untouched =
				() => result.LeftCodeList.ShouldContain("A1");

			It should_have_right_untouched = 
				() => result.RightCodeList.ShouldContain("B1");

			Because of =
				() => result = new PickAkin(left, right).Pick();

			Establish context =
				() => {
					left = new List<string> { "A1" };
					right = new List<string> { "B1" };
				};

			static List<string> left, right;
			static PickAkinResult result;
		}

		public class when_left_contains_two_akin_and_one_disjunct_product_of_right {
			It should_have_both_from_left_and_right_in_akin =
				() => result.AkinList.ShouldContain(new [] {"A1", "A2", "A3"});

			It should_have_one_disjunct_product_in_left =
				() => result.LeftCodeList.ShouldContain("C1");

			It should_have_one_disjunct_product_in_right =
				() => result.RightCodeList.ShouldContain("B1");

			Because of =
				() => result = new PickAkin(left, right).Pick();

			Establish context =
				() => {
					left = new List<string> { "A1", "A3", "C1" };
					right = new List<string> { "A2", "B1" };
				};

			static List<string> left, right;
			static PickAkinResult result;
		}
	}
}
