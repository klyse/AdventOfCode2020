using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day6;

namespace Test
{
	public class Day6Test
	{
		private const string BasePath = "Day6";
		private const string FileName = "day6.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day6Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day6Solver();
		}

		// add two new lines at end of file
		[Test]
		public void Star1()
		{
			_input = FileHelpers.Read(_filePath);

			var solution = _solver.Star1(_input);

			Console.WriteLine(solution);
			Assert.AreEqual(6583, solution);
		}

		[Test]
		public void Star1_Test1()
		{
			_input = new[]
			{
				"abc",
				"",
				"a",
				"b",
				"c",
				"",
				"ab",
				"ac",
				"",
				"a",
				"a",
				"a",
				"a",
				"",
				"b",
				""
			};

			var solution = _solver.Star1(_input);

			Console.WriteLine(solution);
			Assert.AreEqual(11, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);

			var solution = _solver.Star2(_input);

			Console.WriteLine(solution);
			Assert.AreEqual(3290, solution);
		}

		[Test]
		public void Star2_Test1()
		{
			_input = new[]
			{
				"abc",
				"",
				"a",
				"b",
				"c",
				"",
				"ab",
				"ac",
				"",
				"a",
				"a",
				"a",
				"a",
				"",
				"b",
				""
			};

			var solution = _solver.Star2(_input);

			Console.WriteLine(solution);
			Assert.AreEqual(6, solution);
		}
	}
}