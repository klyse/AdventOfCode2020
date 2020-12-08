using System.Collections.Generic;

namespace Solver.Challenges.Day8
{
	public sealed record Instruction(string Operation, int Argument, int Index);
	public sealed record Day8Input(IList<Instruction> Instructions);
}