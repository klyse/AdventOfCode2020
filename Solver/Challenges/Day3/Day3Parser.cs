using System;
using NeoMatrix;
using Solver.Base;

namespace Solver.Challenges.Day3
{
	public class Day3Parser : IParser<Day3Input>
	{
		public Day3Input Parse(string[] values)
		{
			var rows = values.Length;
			var columns = values[0].Length;

			var matrix = Matrix<CellType>.NewMatrix(rows, columns, (row, column) =>
			{
				return values[row][column] switch
				{
					'#' => CellType.Tree,
					'.' => CellType.Space,
					_ => throw new Exception("not found")
				};
			});

			return new Day3Input(matrix);
		}
	}
}