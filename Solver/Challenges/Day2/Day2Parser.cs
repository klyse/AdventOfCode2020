using System.Linq;
using Solver.Base;

namespace Solver.Challenges.Day2
{
	public class Day2Parser : IParser<Day2Input>
	{
		public Day2Input Parse(string[] values)
		{
			var expenses = values.Select(int.Parse);

			return new Day2Input(expenses);
		}
	}
}