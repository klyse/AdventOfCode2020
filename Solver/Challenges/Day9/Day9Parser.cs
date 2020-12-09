using System.Linq;

namespace Solver.Challenges.Day9
{
	public class Day9Parser
	{
		public Day9Input Parse(int preamble, string[] values)
		{
			var numbers = values.Select(double.Parse).ToList();

			return new Day9Input(preamble, numbers);
		}
	}
}