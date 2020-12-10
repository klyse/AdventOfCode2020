using System.Collections.Generic;
using System.Linq;
using Solver.Base;

namespace Solver.Challenges.Day10
{
	public class Day10Parser : IParser<IReadOnlyCollection<int>>
	{
		public IReadOnlyCollection<int> Parse(string[] values)
		{
			return values.Select(int.Parse).ToList();
		}
	}
}