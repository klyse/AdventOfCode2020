using System;
using System.Collections.Generic;
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
		private IReadOnlyCollection<int> _parsedInput;
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
			Assert.AreEqual(2343, solution);
		}

		[Test]
		public void Star1_Test1()
		{
			_input = new[]
			{
				"16",
				"10",
				"15",
				"5",
				"1",
				"11",
				"7",
				"19",
				"6",
				"12",
				"4"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(7 * 5, solution);
		}

		[Test]
		public void Star1_Test2()
		{
			_input = new[]
			{
				"28",
				"33",
				"18",
				"42",
				"31",
				"14",
				"46",
				"20",
				"48",
				"47",
				"24",
				"23",
				"49",
				"45",
				"19",
				"38",
				"39",
				"11",
				"1",
				"32",
				"25",
				"35",
				"8",
				"17",
				"7",
				"9",
				"4",
				"2",
				"34",
				"10",
				"3"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(22 * 10, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(31581162962944, solution);
		}


		[Test]
		public void Star2_Test1()
		{
			_input = new[]
			{
				"16",
				"10",
				"15",
				"5",
				"1",
				"11",
				"7",
				"19",
				"6",
				"12",
				"4"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(8, solution);
		}

		[Test]
		public void Star2_Test2()
		{
			_input = new[]
			{
				"28",
				"33",
				"18",
				"42",
				"31",
				"14",
				"46",
				"20",
				"48",
				"47",
				"24",
				"23",
				"49",
				"45",
				"19",
				"38",
				"39",
				"11",
				"1",
				"32",
				"25",
				"35",
				"8",
				"17",
				"7",
				"9",
				"4",
				"2",
				"34",
				"10",
				"3"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(19208, solution);
		}
	}
}