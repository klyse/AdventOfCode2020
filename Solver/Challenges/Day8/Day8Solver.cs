using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

			var strs = input.Instructions.Select(r => $"{r.Operation}	{r.Argument:000}:	{r.Index} {(visitedIndexes.Contains(r.Index) ? 'y' : 'n')} {r.Index + r.Argument}");

			FileHelpers.Write("Day8", "testOut", strs.ToArray());

			return accumulator;
		}

		public int Star2(Day8Input input)
		{
			var possibleChanges = input.Instructions
				.Where(r => r.Operation == "nop" ||
				            r.Operation == "jmp")
				.Select(r => new
				{
					r.Operation,
					MaxIndex = r.Index + r.Argument,
					r.Index,
					r.Argument
				})
				.ToList();

			foreach (var change in possibleChanges)
			{
				var clone = new List<Instruction>(input.Instructions);

				var newOp = change.Operation == "jmp" ? "nop" : "jmp";
				clone[change.Index] = new Instruction(newOp, change.Argument, change.Index);

				var trial = Trial(clone);
				if (trial != -1) return trial;
			}

			throw new Exception("error");
		}

		private int Trial(IList<Instruction> instructions)
		{
			var accumulator = 0;
			var index = 0;

			var visitedIndexes = new HashSet<int>();
			while (index < instructions.Count)
			{
				var instruction = instructions[index];

				if (visitedIndexes.Contains(index))
					return -1;

				visitedIndexes.Add(index);

				switch (instruction.Operation)
				{
					case "nop":
						index++;
						if (index + instruction.Argument >= 600)
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