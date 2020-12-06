using System;
using System.Linq;
using Solver.Base;

namespace Solver.Challenges.Day7
{
	public class Day7Solver : ISolver<int, Day7Input>
	{
		public int Star1(Day7Input input)
		{
			return input.Commands.Max(GetSeatId);
		}

		public int Star2(Day7Input input)
		{
			var setIds = input.Commands
				.Select(GetSeatId)
				.OrderBy(c => c)
				.ToList();

			for (var i = 0; i < setIds.Max(); i++)
				if (!setIds.Contains(i) &&
				    setIds.Contains(i - 1) &&
				    setIds.Contains(i + 1))
					return i;

			throw new Exception("not found");
		}

		public (int, int) GetRowColumnNumber(string command)
		{
			var min = 0;
			var max = 127;
			var minC = 0;
			var maxC = 7;

			foreach (var t in command)
				switch (t)
				{
					case 'F':
						max = min + (max - min) / 2;
						break;
					case 'B':
						min = min + (max - min) / 2 + 1;
						break;
					case 'R':
						minC = minC + (maxC - minC) / 2 + 1;
						break;
					case 'L':
						maxC = minC + (maxC - minC) / 2;
						break;
				}

			return (min, minC);
		}

		public int GetSeatId(string command)
		{
			var (row, column) = GetRowColumnNumber(command);

			return row * 8 + column;
		}
	}
}