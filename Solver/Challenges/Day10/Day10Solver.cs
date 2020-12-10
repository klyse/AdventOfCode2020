using System.Collections.Generic;
using System.Linq;

namespace Solver.Challenges.Day10
{
	public class Day10Solver
	{
		public int Star1(IReadOnlyCollection<int> input)
		{
			var deviceJolt = input.Max() + 3;

			var orderedJolt = input
				.OrderBy(x => x)
				.ToList();

			var differences = new Dictionary<int, int> {{1, 0}, {2, 0}, {3, 0}};

			var minDiff = orderedJolt[0];
			var maxDiff = deviceJolt - orderedJolt[^1];
			differences[minDiff]++;
			differences[maxDiff]++;

			for (var i = 0; i < input.Count - 1; i++)
			{
				var diff = orderedJolt[i + 1] - orderedJolt[i];

				differences[diff]++;
			}

			return differences[1] * differences[3];
		}

		public long Star2(IReadOnlyCollection<int> input)
		{
			var modInput = input.ToList();
			modInput.Add(0);
			modInput.Add(modInput.Max() + 3);

			modInput = modInput
				.OrderBy(r => r)
				.ToList();

			var differentPossibilities = new Dictionary<int, long>();

			long Possibilities(int i)
			{
				if (i == modInput.Count - 1)
					return 1;

				if (differentPossibilities.ContainsKey(i))
					return differentPossibilities[i];

				long res = 0;

				for (var j = i + 1; j < modInput.Count; j++)
					if (modInput[j] - modInput[i] <= 3)
						res += Possibilities(j);

				differentPossibilities[i] = res;
				return res;
			}

			return Possibilities(0);
		}
	}
}