using System.Linq;
using Solver.Base;

namespace Solver.Challenges.Day13
{
	public class Day13Parser : IParser<Day13Input>
	{
		public Day13Input Parse(string[] values)
		{
			return new(int.Parse(values[0]),
				values[1].Split(',').Select(r => r == "x" ? "0" : r).Select(int.Parse));
		}
	}
}