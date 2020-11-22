namespace Solver.Base
{
	public interface IParser<out TType>
	{
		TType Parse(string[] values);
	}
}