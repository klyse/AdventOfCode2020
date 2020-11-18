using System.Collections.Generic;
using System.Linq;
using Solver.Base;

namespace Solver.Algorithms.Day1
{
	public sealed record Day1Input(IEnumerable<int> Modules);

	public class Day1Parser : IInput<Day1Input>
	{
		public Day1Input Parse(string[] values)
		{
			var modules = values.Select(int.Parse);

			return new Day1Input(modules);
		}
	}
}