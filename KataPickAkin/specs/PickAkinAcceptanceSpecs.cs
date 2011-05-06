using System;
using System.Collections.Generic;

using Machine.Specifications;

namespace KataPickAkin {
	public class PickAkinAcceptanceSpecs {
		public class when_having_lists_as_given_in_acceptance_case_1 {
			It should_have_c1_e1_e2_in_left_list = 
				() => result.LeftCodeList.ShouldContain(new [] {"C1", "E1", "E2"});

			It should_have_f1_in_right_list = 
				() => result.RightCodeList.ShouldContain("F1");

			It should_have_a1_a2_a3_a4_b1_b2_b3_d1_d2_in_akin = 
				() => result.AkinList.ShouldContain(new [] {"A1", "A2", "A3", "A4", "B1", "B2", "B3", "D1", "D2"});

			Because of =
				() => result = new PickAkin(left, right).Pick();

			Establish context =
				() => {
					left = new List<string> { "A1", "B1", "A2", "A3", "C1", "D1", "E1", "E2" };
					right = new List<string> { "F1", "D2", "B2", "B3", "A4" };
				};

			static List<string> left, right;
			static PickAkinResult result;
		}
	}
}
