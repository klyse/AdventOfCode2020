using System.Collections.Generic;
using NeoMatrix;

namespace Solver.Challenges.Day4
{
	
	public sealed record Passport(string PassportString, int Byr, int Iyr, int Eyr, int Hgt, string HgtType, string Hcl, string Ecl, string Pid);
	public sealed record Day4Input(IEnumerable<Passport> Passports);
}