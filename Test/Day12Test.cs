using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day12;

namespace Test
{
	public class Day12Test
	{
		private const string BasePath = "Day12";
		private const string FileName = "day12.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day12Input _parsedInput;
		private Day12Parser _parser;
		private Day12Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day12Solver();
			_parser = new Day12Parser();
		}

		[Test]
		public void Star1()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(362, solution);
		}

		[Test]
		public void Star1_Test1()
		{
			_input = new[]
			{
				"F10",
				"N3",
				"F7",
				"R90",
				"F11"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(25, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(29895, solution);
		}

		[Test]
		public void Star2_Test1()
		{
			_input = new[]
			{
				"F10",
				"N3",
				"F7",
				"R90",
				"F11"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(286, solution);
		}
	}
}