using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day13;

namespace Test
{
	public class Day13Test
	{
		private const string BasePath = "Day13";
		private const string FileName = "day13.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day13Input _parsedInput;
		private Day13Parser _parser;
		private Day13Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day13Solver();
			_parser = new Day13Parser();
		}

		[Test]
		public void Star1()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(1915, solution);
		}

		[Test]
		public void Star1_Test1()
		{
			_input = new[]
			{
				"939",
				"7,13,x,x,59,x,31,19"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(295, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(294354277694107m, solution);
		}

		[Test]
		public void Star2_Test1()
		{
			_input = new[]
			{
				"0",
				"7,13,x,x,59,x,31,19"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(1068781m, solution);
		}

		[Test]
		public void Star2_Test2()
		{
			_input = new[]
			{
				"0",
				"17,x,13,19"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(3417m, solution);
		}

		[Test]
		public void Star2_Test3()
		{
			_input = new[]
			{
				"0",
				"67,7,59,61"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(754018m, solution);
		}

		[Test]
		public void Star2_Test4()
		{
			_input = new[]
			{
				"0",
				"67,x,7,59,61"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(779210m, solution);
		}

		[Test]
		public void Star2_Test5()
		{
			_input = new[]
			{
				"0",
				"67,7,x,59,61"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(1261476m, solution);
		}

		[Test]
		public void Star2_Test6()
		{
			_input = new[]
			{
				"0",
				"1789,37,47,1889"
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(1202161486m, solution);
		}
	}
}