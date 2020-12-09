using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day10;

namespace Test
{
	public class Day10Test
	{
		private const string BasePath = "Day10";
		private const string FileName = "day10.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day10Input _parsedInput;
		private Day10Parser _parser;
		private Day10Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day10Solver();
			_parser = new Day10Parser();
		}

		[Test]
		public void Star1()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(1124361034, solution);
		}

		[Test]
		public void Star1_Test1()
		{
			_input = new[]
			{
				"35",
				"20",
				"15",
				"25",
				"47",
				"40",
				"62",
				"55",
				"65",
				"95",
				"102",
				"117",
				"150",
				"182",
				"127",
				"219",
				"299",
				"277",
				"309",
				"576"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(127, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(129444555, solution);
		}

		[Test]
		public void Star2_Test1()
		{
			_input = new[]
			{
				"35",
				"20",
				"15",
				"25",
				"47",
				"40",
				"62",
				"55",
				"65",
				"95",
				"102",
				"117",
				"150",
				"182",
				"127",
				"219",
				"299",
				"277",
				"309",
				"576"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(62, solution);
		}
	}
}