using System;
using System.Linq;
using System.Collections.Generic;

namespace KataPickAkin {
	public class PickAkin {
		public PickAkin(List<string> leftCodes, List<string> rightCodes) {
			LeftCodeList = leftCodes; RightCodeList = rightCodes;
		}

		public List<string> LeftCodeList { get; private set; }
		public List<string> RightCodeList { get; private set; }

		public PickAkinResult Pick() {
			var left = LeftCodeList;
			var right = RightCodeList;

			var akin = left
				.Where(l => right.Any(r => AreAkin(l, r)))
				.Union(right
					.Where(r => left.Any(l => AreAkin(l, r)))
				)
				.ToList();

			return new PickAkinResult {
				LeftCodeList = left
					.Except(akin)
					.ToList(),
				
				RightCodeList = right
					.Except(akin)
					.ToList(),

				AkinList = akin
			};
		}

		private bool AreAkin(string leftCode, string rightCode) {
			return leftCode[0] == rightCode[0];
		}
	}
}
