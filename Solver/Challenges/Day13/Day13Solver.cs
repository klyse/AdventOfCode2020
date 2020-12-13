using System.Collections.Generic;
using System.Linq;

namespace Solver.Challenges.Day13
{
	public class Day13Solver
	{
		public decimal Star1(Day13Input input)
		{
			var time = input.Arrival;
			var validIds = input.BusIds.Where(r => r > 0).ToList();
			while (true)
			{
				foreach (var inputBusId in validIds)
				{
					if (time % inputBusId == 0)
						return (time - input.Arrival) * inputBusId;
				}

				time++;
			}
		}

		private static decimal GetStep(decimal time, int busId, IDictionary<int, decimal> numbers)
		{
			if (busId == 0)
				return time;

			var step = numbers[0];

			while (true)
			{
				if ((time + numbers.Count) % busId == 0 &&
				    numbers.All(r => (time + r.Key) % r.Value == 0))
					return time;

				time += step;
			}
		}

		public decimal Star2(Day13Input input)
		{
			var busIds = input.BusIds.ToList();

			var time = 0m;
			var dict = new Dictionary<int, decimal> {{0, busIds[0]}};
			for (var i = 1; i < busIds.Count; i++)
			{
				time = GetStep(time, busIds[i], dict);
				dict.Add(i, busIds[i] == 0 ? 1 : busIds[i]);
			}

			return time;
		}
	}
}