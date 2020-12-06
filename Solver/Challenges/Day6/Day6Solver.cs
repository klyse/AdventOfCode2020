using System.Collections.Generic;
using System.Linq;
using Solver.Base;

namespace Solver.Challenges.Day6
{
	public class Day6Solver : ISolver<int, string[]>
	{
		public int Star1(string[] input)
		{
			var count = 0;
			var q = new List<char>();
			foreach (var s in input)
				if (string.IsNullOrWhiteSpace(s))
				{
					count += q
						.GroupBy(r => r, r => r)
						.Count();

					q = new List<char>();
				}
				else
				{
					q.AddRange(s);
				}

			return count;
		}

		public int Star2(string[] input)
		{
			var count = 0;
			var q = new List<char>();
			var ppl = 0;
			foreach (var s in input)
				if (string.IsNullOrWhiteSpace(s))
				{
					count += q
						.GroupBy(r => r, r => r)
						.Count(r => r.Count() == ppl);

					q = new List<char>();
					ppl = 0;
				}
				else
				{
					q.AddRange(s);
					ppl++;
				}

			return count;
		}
	}
}