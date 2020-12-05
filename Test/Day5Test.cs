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
			Assert.AreEqual(883, solution);
		}

		[Test]
		public void GetRowColumn_Test1()
		{
			var (row, column) = _solver.GetRowColumnNumber("FBFBBFFRLR");
			Assert.AreEqual(44, row);
			Assert.AreEqual(5, column);
		}

		[Test]
		public void GetRowColumn_Test2()
		{
			var (row, column) = _solver.GetRowColumnNumber("BFFFBBFRRR");
			Assert.AreEqual(70, row);
			Assert.AreEqual(7, column);
		}

		[Test]
		public void GetRowColumn_Test3()
		{
			var (row, column) = _solver.GetRowColumnNumber("FFFBBBFRRR");
			Assert.AreEqual(14, row);
			Assert.AreEqual(7, column);
		}

		[Test]
		public void GetRowColumn_Test4()
		{
			var (row, column) = _solver.GetRowColumnNumber("BBFFBBFRLL");
			Assert.AreEqual(102, row);
			Assert.AreEqual(4, column);
		}


		[Test]
		[TestCase("FBFBBFFRLR", ExpectedResult = 357)]
		[TestCase("BFFFBBFRRR", ExpectedResult = 567)]
		[TestCase("FFFBBBFRRR", ExpectedResult = 119)]
		[TestCase("BBFFBBFRLL", ExpectedResult = 820)]
		public int GetSeatId_Test1(string command)
		{
			var seatId = _solver.GetSeatId(command);
			return seatId;
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(532, solution);
		}
	}
}