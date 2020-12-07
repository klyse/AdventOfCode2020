using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solver.Challenges.Day7
{
	public class Day7Solver
	{
		private void AssignCanContain(ICollection<Bag> tree)
		{
			foreach (var item in tree)
			foreach (var bag in item.CanContain)
				bag.CanContain = tree.First(r => r.Color == bag.Color).CanContain;
		}

		public int Star1(string[] input)
		{
			var tree = new List<Bag>();
			foreach (var s in input)
			{
				var splitString = s.Split(new[] {"bags", "contain", ",", ".", "bag"},
					StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

				var bag = new Bag
				{
					Color = splitString[0]
				};
				tree.Add(bag);

				if (splitString.Contains("no other"))
					continue;

				foreach (var s1 in splitString.Skip(1))
					bag.CanContain.Add(new Bag
					{
						Count = int.Parse(Regex.Match(s1, @"\d").Value),
						Color = Regex.Match(s1, @"(?<=\d\s).*").Value
					});
			}

			AssignCanContain(tree);

			var shinyGoldContainingBags = tree.Count(r => r.CanContainColor("shiny gold"));

			return shinyGoldContainingBags;
		}

		public int Star2(string[] input)
		{
			var tree = new List<Bag>();
			foreach (var s in input)
			{
				var splitString = s.Split(new[] {"bags", "contain", ",", ".", "bag"},
					StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

				var bag = new Bag
				{
					Color = splitString[0]
				};
				tree.Add(bag);

				if (splitString.Contains("no other"))
					continue;

				foreach (var s1 in splitString.Skip(1))
					bag.CanContain.Add(new Bag
					{
						Count = int.Parse(Regex.Match(s1, @"\d").Value),
						Color = Regex.Match(s1, @"(?<=\d\s).*").Value
					});
			}

			AssignCanContain(tree);

			var shinyGoldBag = tree.First(r => r.Color == "shiny gold");

			return shinyGoldBag.SubBagsCount();
		}
	}
}