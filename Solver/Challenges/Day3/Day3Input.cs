using NeoMatrix;

namespace Solver.Challenges.Day3
{
	public enum CellType
	{
		Tree,
		Space
	}

	public sealed record Day3Input(Matrix<CellType> Matrix);
}