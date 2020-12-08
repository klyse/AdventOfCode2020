using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day9;

namespace Test
{
	public class Day9Test
	{
		private const string BasePath = "Day9";
		private const string FileName = "day9.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day9Input _parsedInput;
		private Day9Parser _parser;
		private Day9Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day9Solver();
			_parser = new Day9Parser();
		}

		[Test]
		public void Star1()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(1675, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(1532, solution);
		}
	}
}