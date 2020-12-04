using System.Linq;
using System.Text.RegularExpressions;
using Solver.Base;

namespace Solver.Challenges.Day4
{
	public class Day4Solver : ISolver<int, Day4Input>
	{
		public int Star1(Day4Input input)
		{
			var validPassports = input.Passports
				.Where(r => r.PassportString.Contains("byr:") &&
				            r.PassportString.Contains("iyr:") &&
				            r.PassportString.Contains("eyr:") &&
				            r.PassportString.Contains("hgt:") &&
				            r.PassportString.Contains("hcl:") &&
				            r.PassportString.Contains("ecl:") &&
				            r.PassportString.Contains("pid:"));

			return validPassports.Count();
		}

		public int Star2(Day4Input input)
		{
			var validEyeColors = new[] {"amb", "blu", "brn", "gry", "grn", "hzl", "oth"};
			var validPassports = input.Passports
				.Where(r => r.PassportString.Contains("byr:") &&
				            r.PassportString.Contains("iyr:") &&
				            r.PassportString.Contains("eyr:") &&
				            r.PassportString.Contains("hgt:") &&
				            r.PassportString.Contains("hcl:") &&
				            r.PassportString.Contains("ecl:") &&
				            r.PassportString.Contains("pid:"))
				.Where(r => r.Byr >= 1920 && r.Byr <= 2002 &&
				            r.Iyr >= 2010 && r.Iyr <= 2020 &&
				            r.Eyr >= 2020 && r.Eyr <= 2030 &&
				            (r.HgtType == "cm" || r.HgtType == "in") &&
				            (r.HgtType == "cm" && r.Hgt >= 150 && r.Hgt <= 193 ||
				             r.HgtType == "in" && r.Hgt >= 59 && r.Hgt <= 76) &&
				            Regex.IsMatch(r.Hcl, @"^#[0-9a-f]{6}$") &&
				            validEyeColors.Contains(r.Ecl) &&
				            Regex.IsMatch(r.Pid, @"^\d{9}$"));

			return validPassports.Count();
		}
	}
}