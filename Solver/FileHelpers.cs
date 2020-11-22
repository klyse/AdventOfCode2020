using System;
using System.Collections.Generic;
using System.IO;

namespace Solver
{
	public static class FileHelpers
	{
		public static string[] Read(int day)
		{
			var filePath = EnvironmentConstants.InputPath(day);
			var readAllLines = File.ReadAllLines(filePath);
			return readAllLines;
		}

		public static void Write(int day, string fileName, string[] lines)
		{
			var filePath = Path.Combine(EnvironmentConstants.OutputPath(day), fileName);

			if (!Directory.Exists(EnvironmentConstants.OutputPath(day)))
				Directory.CreateDirectory(EnvironmentConstants.OutputPath(day));

			File.WriteAllLines(filePath, lines);

			Console.WriteLine($"Wrote output data to: {filePath}");
		}

		public static void Write(int day, string fileName, string line)
		{
			Write(day, fileName, new List<string> {line}.ToArray());
		}
	}
}