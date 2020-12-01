using System.Linq;
using Solver.Base;

namespace Solver.Challenges.Day1
{
	public class Day1Parser : IParser<Day1Input>
	{
		public Day1Input Parse(string[] values)
		{
			var expenses = values.Select(int.Parse);

			return new Day1Input(expenses);
		}
	}
}