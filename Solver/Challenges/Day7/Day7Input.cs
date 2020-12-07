using System.Collections.Generic;
using System.Linq;

namespace Solver.Challenges.Day7
{
	public sealed class Bag
	{
		public string Color { get; init; }
		public Bag Parent { get; set; }
		public ICollection<Bag> CanContain { get; set; }
		public int Count { get; init; }

		public Bag()
		{
			CanContain = new List<Bag>();
		}

		public bool CanContainColor(string color)
		{
			return CanContain.Any(r => r.Color == color) ||
			       CanContain.Any(q => q.CanContainColor(color));
		}
	}
}