using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day11;

namespace Test
{
	public class Day11Test
	{
		private const string BasePath = "Day11";
		private const string FileName = "day11.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day11Input _parsedInput;
		private Day11Parser _parser;
		private Day11Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day11Solver();
			_parser = new Day11Parser();
		}

		[Test]
		public void Star1()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(2296, solution);
		}

		[Test]
		public void Star1_Test1()
		{
			_input = new[]
			{
				"L.LL.LL.LL",
				"LLLLLLL.LL",
				"L.L.L..L..",
				"LLLL.LL.LL",
				"L.LL.LL.LL",
				"L.LLLLL.LL",
				"..L.L.....",
				"LLLLLLLLLL",
				"L.LLLLLL.L",
				"L.LLLLL.LL"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(37, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(2089, solution);
		}


		[Test]
		public void GetOccupiedSeats_Test1()
		{
			_input = new[]
			{
				".......#.",
				"...#.....",
				".#.......",
				".........",
				"..#L....#",
				"....#....",
				".........",
				"#........",
				"...#....."
			};
			_parsedInput = _parser.Parse(_input);

			var solution = Day11Solver.GetOccupiedSeats(_parsedInput.Matrix, 3, 4);

			Console.WriteLine(solution);
			Assert.AreEqual(8, solution);
		}

		[Test]
		public void GetOccupiedSeats_Test2()
		{
			_input = new[]
			{
				".##.##.",
				"#.#.#.#",
				"##...##",
				"...L...",
				"##...##",
				"#.#.#.#",
				".##.##."
			};
			_parsedInput = _parser.Parse(_input);

			var solution = Day11Solver.GetOccupiedSeats(_parsedInput.Matrix, 3, 3);

			Console.WriteLine(solution);
			Assert.AreEqual(0, solution);
		}

		[Test]
		public void GetOccupiedSeats_Test3()
		{
			_input = new[]
			{
				".............",
				".L.L.#.#.#.#.",
				"............."
			};
			_parsedInput = _parser.Parse(_input);

			var solution = Day11Solver.GetOccupiedSeats(_parsedInput.Matrix, 1, 1);

			Console.WriteLine(solution);
			Assert.AreEqual(0, solution);
		}

		[Test]
		public void Star2_Test1()
		{
			_input = new[]
			{
				"L.LL.LL.LL",
				"LLLLLLL.LL",
				"L.L.L..L..",
				"LLLL.LL.LL",
				"L.LL.LL.LL",
				"L.LLLLL.LL",
				"..L.L.....",
				"LLLLLLLLLL",
				"L.LLLLLL.L",
				"L.LLLLL.LL"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(26, solution);
		}
	}
}