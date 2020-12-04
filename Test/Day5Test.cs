using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day5;

namespace Test
{
	public class Day5Test
	{
		private const string BasePath = "Day5";
		private const string FileName = "day5.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day5Input _parsedInput;
		private Day5Parser _parser;
		private Day5Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day5Solver();
			_parser = new Day5Parser();
		}

		[Test]
		public void Star1()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(260, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(153, solution);
		}
	}
}