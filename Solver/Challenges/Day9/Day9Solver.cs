using System;
using System.Linq;
using Solver.Base;

namespace Solver.Challenges.Day9
{
	public class Day9Solver : ISolver<double, Day9Input>
	{
		public double Star1(Day9Input input)
		{
			for (var i = input.Preamble; i < input.Numbers.Count; i++)
			{
				var number = input.Numbers[i];

				var notFoundSum = false;

				for (var x1 = i - input.Preamble; x1 < i && !notFoundSum; x1++)
				{
					for (var x2 = i - input.Preamble + 1; x2 < i; x2++)
					{
						// ReSharper disable once CompareOfFloatsByEqualityOperator
						if (input.Numbers[x1] == input.Numbers[x2])
							continue;
						// ReSharper disable once CompareOfFloatsByEqualityOperator
						if (input.Numbers[x1] + input.Numbers[x2] == number)
						{
							notFoundSum = true;
							break;
						}
					}
				}

				if (!notFoundSum)
					return number;
			}

			throw new Exception("not found");
		}

		public double Star2(Day9Input input)
		{
			return 0;
		}
	}
}