using System;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day1;

namespace Test
{
	public class Day1Test
	{
		private string[] _input;
		private Day1Parser _parser;
		private Day1Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day1Solver();
			_parser = new Day1Parser();
			_input = FileHelpers.Read(1);
		}

		[Test]
		public void Star1()
		{
			var input = _parser.Parse(_input);
			var solution = _solver.Star1(input);

			Console.WriteLine(solution);
			Assert.AreEqual(3212842, solution);
		}

		[Test]
		public void Star2()
		{
			var input = _parser.Parse(_input);
			var solution = _solver.Star2(input);

			Console.WriteLine(solution);
			Assert.AreEqual(4816402, solution);
		}
	}
}