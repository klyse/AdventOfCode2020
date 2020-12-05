using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day5;
using Solver.Challenges.Day6;

namespace Test
{
	public class Day6Test
	{
		private const string BasePath = "Day6";
		private const string FileName = "day6.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day6Input _parsedInput;
		private Day6Parser _parser;
		private Day6Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day6Solver();
			_parser = new Day6Parser();
		}

		[Test]
		public void Star1()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(883, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(532, solution);
		}
	}
}