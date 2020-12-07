using System.Collections.Generic;
using System.Linq;
using Solver.Base;

namespace Solver.Challenges.Day7
{
	public class Day7Solver : ISolver<int, IReadOnlyCollection<Bag>>
	{
		public int Star1(IReadOnlyCollection<Bag> tree)
		{
			var shinyGoldContainingBags = tree.Count(r => r.CanContainColor("shiny gold"));

			return shinyGoldContainingBags;
		}

		public int Star2(IReadOnlyCollection<Bag> tree)
		{
			var shinyGoldBag = tree.First(r => r.Color == "shiny gold");

			return shinyGoldBag.SubBagsCount();
		}
	}
}