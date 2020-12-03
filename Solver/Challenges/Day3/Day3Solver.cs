using Solver.Base;

namespace Solver.Challenges.Day3
{
	public class Day3Solver : ISolver<decimal, Day3Input>
	{
		public decimal Star1(Day3Input input)
		{
			var treeCount = CalculateEncounteringTrees(input, 1, 3);

			return treeCount;
		}

		public decimal Star2(Day3Input input)
		{
			var trees = new decimal[]
			{
				CalculateEncounteringTrees(input, 1, 1),
				CalculateEncounteringTrees(input, 1, 3),
				CalculateEncounteringTrees(input, 1, 5),
				CalculateEncounteringTrees(input, 1, 7),
				CalculateEncounteringTrees(input, 2, 1)
			};

			decimal sum = 1;
			foreach (var tree in trees) sum *= tree;

			return sum;
		}

		private static int CalculateEncounteringTrees(Day3Input input, int rowStride, int columnSride)
		{
			var treeCount = 0;
			var column = 0;
			for (var row = rowStride; row < input.Matrix.Rows; row += rowStride)
			{
				column += columnSride;
				column %= input.Matrix.Columns;

				if (input.Matrix[row, column] == CellType.Tree)
					treeCount++;
			}

			return treeCount;
		}
	}
}