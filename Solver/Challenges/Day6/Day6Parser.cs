using Solver.Base;

namespace Solver.Challenges.Day6
{
	public class Day6Parser : IParser<Day6Input>
	{
		public Day6Input Parse(string[] values)
		{
			return new(values);
		}
	}
}