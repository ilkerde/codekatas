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

		public PickAkinResult Pick() { return null; }
	}
}
