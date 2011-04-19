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
	}
}
