using System.Collections.Generic;
using System.Linq;
using NeoMatrix;
using Solver.Base;

namespace Solver.Challenges.Day11
{
	public class Day11Solver : ISolver<int, Day11Input>
	{
		public int Star1(Day11Input input)
		{
			var matWithPadding = input.Matrix.AddPadding(1, '.');

			var newMat = matWithPadding.Duplicate();

			while (true)
			{
				var evolution = Evolution1(newMat);


				var flat = newMat.GetFlat();
				var evoFlat = evolution.GetFlat();
				if (flat.SequenceEqual(evoFlat))
				{
					newMat = evolution;
					break;
				}

				newMat = evolution;
			}

			return newMat.GetFlat().Count(c => c == '#');
		}

		public int Star2(Day11Input input)
		{
			var matWithPadding = input.Matrix.AddPadding(1, '.');

			var newMat = matWithPadding.Duplicate();

			while (true)
			{
				var evolution = Evolution2(newMat);


				var flat = newMat.GetFlat();
				var evoFlat = evolution.GetFlat();
				if (flat.SequenceEqual(evoFlat))
				{
					newMat = evolution;
					break;
				}

				newMat = evolution;
			}

			return newMat.GetFlat().Count(c => c == '#');
		}

		private static Matrix<char> Evolution1(Matrix<char> matrix)
		{
			var newMat = matrix.Duplicate();

			matrix.ExecuteOnAll((ch, r, c) =>
			{
				if (ch == '.')
					return;

				var box = matrix.GetBox(r, c, 3);

				var occupied = box.GetFlat().Count(x => x == '#');

				// remove sself because it is also in range
				occupied -= ch == '#' ? 1 : 0;

				if (ch == 'L' && occupied == 0)
					newMat[r, c] = '#';
				else if (ch == '#' && occupied >= 4)
					newMat[r, c] = 'L';
			});

			return newMat;
		}

		private static IEnumerable<char> GetDiagonal1(Matrix<char> matrix, int row, int column)
		{
			var r = row;
			var c = column;
			while (r > 0 && r < matrix.Rows - 1 &&
			       c > 0 && c < matrix.Columns - 1)
			{
				r--;
				c--;
			}

			while (r >= 0 && r < matrix.Rows &&
			       c >= 0 && c < matrix.Columns)
			{
				if (r == row && c == column)
					yield return 'x';
				else
					yield return matrix[r, c];

				r++;
				c++;
			}
		}

		private static IEnumerable<char> GetDiagonal2(Matrix<char> matrix, int row, int column)
		{
			var r = row;
			var c = column;
			while (r > 0 && r < matrix.Rows &&
			       c > 0 && c < matrix.Columns - 1)
			{
				r--;
				c++;
			}


			while (r >= 0 && r < matrix.Rows &&
			       c >= 0 && c < matrix.Columns)
			{
				if (r == row && c == column)
					yield return 'x';
				else
					yield return matrix[r, c];
				r++;
				c--;
			}
		}

		private static char First(IReadOnlyList<char> list, int self)
		{
			for (var i = self - 1; i >= 0; i--)
			{
				if (list[i] == '.')
					continue;
				return list[i];
			}

			return '.';
		}

		private static char Last(IReadOnlyList<char> list, int self)
		{
			for (var i = self + 1; i < list.Count; i++)
			{
				if (list[i] == '.')
					continue;
				return list[i];
			}

			return '.';
		}

		public static int GetOccupiedSeats(Matrix<char> matrix, int c, int r)
		{
			var col = matrix.GetCol(c).ToList();
			var colFirstInfo = First(col, r);
			var colLastInfo = Last(col, r);

			var row = matrix.GetRow(r).ToList();
			var rowFirstInfo = First(row, c);
			var rowLastInfo = Last(row, c);

			var diag1 = GetDiagonal1(matrix, r, c).ToList();
			var diag1FirstInfo = First(diag1, diag1.FindIndex(x => x == 'x'));
			var diag1LeastInfo = Last(diag1, diag1.FindIndex(x => x == 'x'));

			var diag2 = GetDiagonal2(matrix, r, c).ToList();
			var diag2FirstInfo = First(diag2, diag2.FindIndex(x => x == 'x'));
			var diag2LeastInfo = Last(diag2, diag2.FindIndex(x => x == 'x'));

			var occupiedList = new List<char>
			{
				rowFirstInfo,
				rowLastInfo,
				colFirstInfo,
				colLastInfo,
				diag1FirstInfo,
				diag1LeastInfo,
				diag2FirstInfo,
				diag2LeastInfo
			};

			return occupiedList.Count(q => q == '#');
		}

		private static Matrix<char> Evolution2(Matrix<char> matrix)
		{
			var newMat = matrix.Duplicate();

			matrix.ExecuteOnAll((ch, r, c) =>
			{
				if (ch == '.')
					return;

				var occupied = GetOccupiedSeats(matrix, c, r);

				if (ch == 'L' && occupied == 0)
					newMat[r, c] = '#';
				else if (ch == '#' && occupied >= 5)
					newMat[r, c] = 'L';
			});

			return newMat;
		}
	}
}