using System.IO;
using Solver.Base;

namespace Solver
{
	public static class EnvironmentConstants
	{
		// ReSharper disable PossibleNullReferenceException
		public static string DataPath(int day)
		{
			return Path.Combine(new FileInfo(typeof(IParser<bool>).Assembly.Location).Directory.Parent.Parent.Parent.Parent.ToString(), "Solver", "Challenges", "Day" + day);
		}
		// ReSharper restore PossibleNullReferenceException

		public static string InputPath(int day)
		{
			return Path.Combine(DataPath(day), "day" + day + ".in");
		}

		public static string OutputPath(int day)
		{
			return Path.Combine(DataPath(day), "Output");
		}
	}
}