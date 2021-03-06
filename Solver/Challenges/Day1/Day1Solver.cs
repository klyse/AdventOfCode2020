﻿using System;
using Solver.Base;

namespace Solver.Challenges.Day1
{
	public class Day1Solver : ISolver<int, Day1Input>
	{
		public int Star1(Day1Input input)
		{
			foreach (var expense1 in input.Expenses)
			foreach (var expense2 in input.Expenses)
				if (expense1 + expense2 == 2020)
					return expense1 * expense2;

			throw new Exception("not found");
		}

		public int Star2(Day1Input input)
		{
			foreach (var expense1 in input.Expenses)
			foreach (var expense2 in input.Expenses)
			foreach (var expense3 in input.Expenses)
				if (expense1 + expense2 + expense3 == 2020)
					return expense1 * expense2 * expense3;

			throw new Exception("not found");
		}
	}
}