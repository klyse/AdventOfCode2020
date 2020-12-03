using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day4;

namespace Test
{
	public class Day4Test
	{
		private const string BasePath = "Day4";
		private const string FileName = "day4.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day4Input _parsedInput;
		private Day4Parser _parser;
		private Day4Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day4Solver();
			_parser = new Day4Parser();
		}

		[Test]
		public void Star1()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(268, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(3093068400m, solution);
		}
	}
}