using NeoMatrix;
using Solver.Base;

namespace Solver.Challenges.Day11
{
	public class Day11Parser : IParser<Day11Input>
	{
		public Day11Input Parse(string[] values)
		{
			return new(Matrix<char>.NewMatrix(values.Length,
				values[0].Length,
				(r, c) => values[r][c]));
		}
	}
}