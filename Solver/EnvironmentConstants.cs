using System.IO;
using Solver.Base;

namespace Solver
{
	public static class EnvironmentConstants
	{
		// ReSharper disable PossibleNullReferenceException
		public static string DataPath()
		{
			return Path.Combine(new FileInfo(typeof(IParser<bool>).Assembly.Location).Directory.Parent.Parent.Parent.Parent.ToString(), "Solver", "Challenges");
		}
		// ReSharper restore PossibleNullReferenceException

		public static string InputPath(string fileName)
		{
			return Path.Combine(DataPath(), fileName);
		}

		public static string OutputPath(string challenge, string fileName)
		{
			return Path.Combine(DataPath(), challenge, "Output", fileName);
		}
	}
}