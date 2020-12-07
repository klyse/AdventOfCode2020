using System.Collections.Generic;
using System.Linq;

namespace Solver.Challenges.Day7
{
	public sealed record Bag
	{
		public Bag()
		{
			CanContain = new List<Bag>();
		}

		public string Color { get; init; }
		public ICollection<Bag> CanContain { get; set; }
		public int Count { get; init; }

		public int SubBagsCount(int level = 1)
		{
			return CanContain.Sum(r => level * (r.Count + r.SubBagsCount(r.Count)));
		}

		public bool CanContainColor(string color)
		{
			return CanContain.Any(r => r.Color == color) ||
			       CanContain.Any(q => q.CanContainColor(color));
		}
	}
}