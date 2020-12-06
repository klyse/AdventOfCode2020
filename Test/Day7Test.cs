using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day7;

namespace Test
{
	public class Day7Test
	{
		private const string BasePath = "Day7";
		private const string FileName = "day7.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day7Input _parsedInput;
		private Day7Parser _parser;
		private Day7Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day7Solver();
			_parser = new Day7Parser();
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