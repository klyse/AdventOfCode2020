using System.Collections.Generic;
using System.Diagnostics;
using Solver.Base;

namespace Solver.Challenges.Day8
{
	public class Day8Solver : ISolver<int, Day8Input>
	{
		public int Star1(Day8Input input)
		{
			var accumulator = 0;
			var index = 0;
			var visitedIndexes = new HashSet<int>();
			while (!visitedIndexes.Contains(index))
			{
				var instruction = input.Instructions[index];
				visitedIndexes.Add(index);

				switch (instruction.Operation)
				{
					case "nop":
						index++;
						break;
					case "jmp":
						index += instruction.Argument;
						break;
					case "acc":
						accumulator += instruction.Argument;
						index++;
						break;
				}
			}

			return accumulator;
		}

		public int Star2(Day8Input input)
		{
			var accumulator = 0;
			var index = 0;
			var visitedIndexes = new HashSet<int>();
			while (index < input.Instructions.Count)
			{
				var instruction = input.Instructions[index];
				visitedIndexes.Add(index);

				switch (instruction.Operation)
				{
					case "nop":
						index++;
						if (index + instruction.Argument > 594)
							Debugger.Break();
						break;
					case "jmp":
						index += instruction.Argument;
						break;
					case "acc":
						accumulator += instruction.Argument;
						index++;
						break;
				}
			}

			return accumulator;
		}
	}
}