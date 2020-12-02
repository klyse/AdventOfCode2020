using System.Collections.Generic;

namespace Solver.Challenges.Day2
{
	public sealed record Password(int Pos1, int Pos2, char C, string Pwd);

	public sealed record Day2Input(IEnumerable<Password> Passwords);
}