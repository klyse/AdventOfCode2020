using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day2;

namespace Test
{
	public class Day2Test
	{
		private const string BasePath = "Day2";
		private const string FileName = "day2.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day2Input _parsedInput;
		private Day2Parser _parser;
		private Day2Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day2Solver();
			_parser = new Day2Parser();
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
		[TestCase("1-3 a: abcde", ExpectedResult = true)]
		[TestCase("1-3 b: cdefg", ExpectedResult = false)]
		[TestCase("2-9 c: ccccccccc", ExpectedResult = true)]
		public bool Star1_Tests(string input)
		{
			_parsedInput = _parser.Parse(new[] {input});

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			return solution == 1;
		}

		[Test]
		[TestCase("1-3 a: abcde", ExpectedResult = true)]
		[TestCase("1-3 b: cdefg", ExpectedResult = false)]
		[TestCase("2-9 c: ccccccccc", ExpectedResult = false)]
		public bool Star2_Tests(string input)
		{
			_parsedInput = _parser.Parse(new[] {input});

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			return solution == 1;
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