using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Solver.Base;

namespace Solver.Challenges.Day4
{
	public class Day4Parser : IParser<Day4Input>
	{
		string TakeIfExists(Dictionary<string, string> dict, string str)
		{
			if (dict.ContainsKey(str))
				return dict[str];

			return "";
		}

		// add two new lines to the end of the input file!!
		public Day4Input Parse(string[] values)
		{
			var passports = new List<Passport>();
			for (var i = 0; i < values.Length; i++)
			{
				var str = "";
				for (var j = i; j < values.Length; j++)
				{
					if (string.IsNullOrWhiteSpace(values[j]))
					{
						var valueDict = str.Split(' ')
							.Where(r => !string.IsNullOrWhiteSpace(r))
							.ToDictionary(
								r => r.Split(':').First(),
								r => r.Split(':').ElementAt(1));

						var byr = 0;
						int.TryParse(TakeIfExists(valueDict, "byr"), out byr);
						var iyr = 0;
						int.TryParse(TakeIfExists(valueDict, "iyr"), out iyr);
						var eyr = 0;
						int.TryParse(TakeIfExists(valueDict, "eyr"), out eyr);
						var hgtS = TakeIfExists(valueDict, "hgt");
						var hgtMatch = Regex.Match(hgtS, @"[a-z]+");
						var hgtType = "";
						if (hgtMatch.Success)
							hgtType = hgtMatch.Value;
						hgtMatch = Regex.Match(hgtS, @"[0-9]+");
						var hgt = 0;
						if (hgtMatch.Success)
							int.TryParse(hgtMatch.Value, out hgt);

						var hcl = TakeIfExists(valueDict, "hcl");
						var ecl = TakeIfExists(valueDict, "ecl");
						var pid = TakeIfExists(valueDict, "pid");
						var cid = TakeIfExists(valueDict, "cid");

						passports.Add(new Passport(str,
							byr,
							iyr,
							eyr,
							hgt,
							hgtType,
							hcl,
							ecl,
							pid));

						i = j;
						break;
					}

					str = $"{str} {values[j]}";
				}
			}

			return new Day4Input(passports);
		}
	}
}