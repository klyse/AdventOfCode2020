using Solver.Base;

namespace Solver.Challenges.Day7
{
	public class Day7Parser : IParser<Day7Input>
	{
		public Day7Input Parse(string[] values)
		{
			return new(values);
		}
	}
}