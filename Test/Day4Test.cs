using System;
using System.IO;
using NUnit.Framework;
using Solver;
using Solver.Challenges.Day4;

namespace Test
{
	public class Day4Test
	{
		private const string BasePath = "Day4";
		private const string FileName = "day4.in";
		private readonly string _filePath = Path.Combine(BasePath, FileName);

		private string[] _input;
		private Day4Input _parsedInput;
		private Day4Parser _parser;
		private Day4Solver _solver;

		[SetUp]
		public void SetUp()
		{
			_solver = new Day4Solver();
			_parser = new Day4Parser();
		}

		[Test]
		public void Star1()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(260, solution);
		}

		[Test]
		public void Star1_Test1()
		{
			_input = new[]
			{
				"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd",
				"byr:1937 iyr:2017 cid:147 hgt:183cm",
				"",
				"iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884",
				"hcl:#cfa07d byr:1929",
				"",
				"hcl:#ae17e1 iyr:2013",
				"eyr:2024",
				"ecl:brn pid:760753108 byr:1931",
				"hgt:179cm",
				"",
				"hcl:#cfa07d eyr:2025 pid:166559648",
				"iyr:2011 ecl:brn hgt:59in",
				""
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star1(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(2, solution);
		}

		[Test]
		public void Star2()
		{
			_input = FileHelpers.Read(_filePath);
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine("166 too high");
			Console.WriteLine(solution);
			Assert.AreEqual(153, solution);
		}

		[Test]
		public void Star2_Test1()
		{
			_input = new[]
			{
				"eyr:1972 cid:100",
				"hcl:#18171d ecl:amb hgt:170 pid:186cm iyr:2018 byr:1926",
				"",
				"iyr:2019",
				"hcl:#602927 eyr:1967 hgt:170cm",
				"ecl:grn pid:012533040 byr:1946",
				"",
				"hcl:dab227 iyr:2012",
				"ecl:brn hgt:182cm pid:021572410 eyr:2020 byr:1992 cid:277",
				"",
				"hgt:59cm ecl:zzz",
				"eyr:2038 hcl:74454a iyr:2023",
				"pid:3556412378 byr:2007",
				""
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(0, solution);
		}

		[Test]
		public void Star2_Test2()
		{
			_input = new[]
			{
				"pid:087499704 hgt:74in ecl:grn iyr:2012 eyr:2030 byr:1980",
				"hcl:#623a2f",
				"",
				"eyr:2029 ecl:blu cid:129 byr:1989",
				"iyr:2014 pid:896056539 hcl:#a97842 hgt:165cm",
				"",
				"hcl:#888785",
				"hgt:164cm byr:2001 iyr:2015 cid:88",
				"pid:545766238 ecl:hzl",
				"eyr:2022",
				"",
				"iyr:2010 hgt:158cm hcl:#b6652a ecl:blu byr:1944 eyr:2021 pid:093154719",
				""
			};
			_parsedInput = _parser.Parse(_input);

			var solution = _solver.Star2(_parsedInput);

			Console.WriteLine(solution);
			Assert.AreEqual(4, solution);
		}
	}
}