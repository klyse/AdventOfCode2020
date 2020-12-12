using System.Collections.Generic;

namespace Solver.Challenges.Day12
{
	public sealed record Command(char Direction, int Count);

	public sealed record Day12Input(IEnumerable<Command> Commands);
}