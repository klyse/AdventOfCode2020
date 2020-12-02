using System;
using System.Linq;
using Solver.Base;

namespace Solver.Challenges.Day2
{
	public class Day2Parser : IParser<Day2Input>
	{
		public Day2Input Parse(string[] values)
		{
			var expenses = values.Select(s =>
			{
				var splitByMinus = s.Split(new[] {'-', ' ', ':'}, StringSplitOptions.RemoveEmptyEntries);
				return new Password(
					int.Parse(splitByMinus.ElementAt(0)),
					int.Parse(splitByMinus.ElementAt(1)),
					splitByMinus.ElementAt(2)[0],
					splitByMinus.ElementAt(3)
				);
			});

			return new Day2Input(expenses);
		}
	}
}