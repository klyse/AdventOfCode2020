using System;
using System.Collections.Generic;
using System.Linq;
using Solver.Base;

namespace Solver.Challenges.Day13
{
	public class Day13Solver : ISolver<decimal, Day13Input>
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

		public decimal Star2(Day13Input input)
		{
			var busIds = input.BusIds.ToList();

			decimal time = 0;
			decimal step = busIds[0];
			for (var i = 1; i < busIds.Count; i++)
			{
				if (busIds[i] == 0)
					continue;

				while (true)
				{
					time += step;
					if ((time + i) % busIds[i] == 0)
					{
						step *= busIds[i];
						break;
					}
				}
			}

			return time;
		}
	}
}