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

				if (!notFoundSum)
					return number;
			}

			throw new Exception("not found");
		}

		public double Star2(Day9Input input)
		{
			var star1 = Star1(input);

			var sum = 0.0;
			var first = 0;
			var last = 0;
			while (sum != star1)
				if (sum > star1)
				{
					sum -= input.Numbers[first];
					first++;
				}
				else if (sum < star1)
				{
					sum += input.Numbers[last];
					last++;
				}

			var contiguousSet = input.Numbers.Skip(first).Take(last - first).ToList();

			return contiguousSet.Min() +
			       contiguousSet.Max();
		}
	}
}