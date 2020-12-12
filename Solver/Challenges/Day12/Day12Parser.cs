using System.Linq;
using Solver.Base;

namespace Solver.Challenges.Day12
{
	public class Day12Parser : IParser<Day12Input>
	{
		public Day12Input Parse(string[] values)
		{
			var expenses = values.Select(r => new Command(r[0], int.Parse(r.Remove(0, 1))));

			return new Day12Input(expenses);
		}
	}
}