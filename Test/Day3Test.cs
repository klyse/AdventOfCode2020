using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day3;

namespace Test
{
	public class Day3Test
	{
		private const string BasePath = "Day3";
		private const string FileName = "day3.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day3Input _parsedInput;
		private Day3Parser _parser;
		private Day3Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day3Solver();
			_parser = new Day3Parser();
		}

		[Test]
		public void Star1()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(546, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(275, solution);
		}
	}
}