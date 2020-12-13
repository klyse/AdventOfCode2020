using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day14;

namespace Test
{
	public class Day14Test
	{
		private const string BasePath = "Day14";
		private const string FileName = "day14.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day14Input _parsedInput;
		private Day14Parser _parser;
		private Day14Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day14Solver();
			_parser = new Day14Parser();
		}

		[Test]
		public void Star1()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(805731, solution);
		}

		[Test]
		public void Star1_Test1()
		{
			_input = new[]
			{
				"1721",
				"979",
				"366",
				"299",
				"675",
				"1456"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(514579, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(192684960, solution);
		}
	}
}