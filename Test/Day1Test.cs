using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day1;

namespace Test
{
	public class Day1Test
	{
		private const string BasePath = "Day1";
		private const string FileName = "day1.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day1Input _parsedInput;
		private Day1Parser _parser;
		private Day1Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day1Solver();
			_parser = new Day1Parser();
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);
		}

		[Test]
		public void Star1()
		{
			var solution = _solver.Star1(_parsedInput);
			
			Console.WriteLine(solution);
			Assert.AreEqual(3212842, solution);
		}

		[Test]
		public void Star2()
		{
			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(4816402, solution);
		}
	}
}