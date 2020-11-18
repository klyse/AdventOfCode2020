using System;
using NUnit.Framework;
using Solver;
using Solver.Algorithms;
using Solver.Model;

namespace Test
{
	public class Day1Test
	{
		private const string File = "day1.txt";
		private Day1Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day1Solver();
		}

		[Test]
		public void Star1()
		{
			var fileInput = File.Read();
			var input = new Day1Parser().Parse(fileInput);

			var solution = _solver.Star1(input);

			Console.WriteLine(solution);
			Assert.AreEqual(3212842, solution);
		}
		
		[Test]
		public void Star2()
		{
			var fileInput = File.Read();
			var input = new Day1Parser().Parse(fileInput);

			var solution = _solver.Star2(input);

			Console.WriteLine(solution);
			Assert.AreEqual(4816402, solution);
		}
	}
}