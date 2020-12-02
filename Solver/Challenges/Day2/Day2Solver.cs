using System.Linq;
using Solver.Base;

namespace Solver.Challenges.Day2
{
	public class Day2Solver : ISolver<int, Day2Input>
	{
		public int Star1(Day2Input input)
		{
			var correct = 0;
			foreach (var password in input.Passwords)
			{
				var cnt = password.Pwd.Count(c => c == password.C);
				if (cnt >= password.Pos1 && cnt <= password.Pos2)
					correct++;
			}

			return correct;
		}

		public int Star2(Day2Input input)
		{
			var correct = 0;
			foreach (var password in input.Passwords)
				if ((password.Pwd[password.Pos1 - 1] == password.C) ^
				    (password.Pwd[password.Pos2 - 1] == password.C))
					correct++;

			return correct;
		}
	}
}