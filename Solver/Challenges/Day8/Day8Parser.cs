using Solver.Base;

namespace Solver.Challenges.Day8
{
	public class Day8Parser : IParser<Day8Input>
	{
		public Day8Input Parse(string[] values)
		{
			return new(values);
		}
	}
}