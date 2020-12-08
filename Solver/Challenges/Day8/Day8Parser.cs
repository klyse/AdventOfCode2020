using System.Collections.Generic;
using Solver.Base;

namespace Solver.Challenges.Day8
{
	public class Day8Parser : IParser<Day8Input>
	{
		public Day8Input Parse(string[] values)
		{
			var instructions = new List<Instruction>();
			var index = 0;
			foreach (var value in values)
			{
				var split = value.Split(' ');
				instructions.Add(
					new Instruction(split[0],
						int.Parse(split[1]),
						index));
				index++;
			}

			return new Day8Input(instructions);
		}
	}
}