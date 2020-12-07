using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day8;

namespace Test
{
	public class Day8Test
	{
		private const string BasePath = "Day8";
		private const string FileName = "day8.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day8Input _parsedInput;
		private Day8Parser _parser;
		private Day8Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day8Solver();
			_parser = new Day8Parser();
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