using System;
using System.Collections.Generic;
using System.IO;

namespace Solver
{
	public static class FileHelpers
	{
		public static string[] Read(string fileName)
		{
			var filePath = EnvironmentConstants.InputPath(fileName);
			var readAllLines = File.ReadAllLines(filePath);
			return readAllLines;
		}

		public static void Write(string challenge, string fileName, string[] lines)
		{
			var filePath = EnvironmentConstants.OutputPath(challenge, fileName);
			var fileDirectory = Path.GetDirectoryName(filePath);
			if (string.IsNullOrWhiteSpace(fileDirectory))
				throw new NullReferenceException("Directory does not exist");

			Directory.CreateDirectory(fileDirectory);

			File.WriteAllLines(filePath, lines);

			Console.WriteLine($"Wrote output data to: {filePath}");
		}

		public static void Write(string challenge, string fileName, string line)
		{
			Write(challenge, fileName, new List<string> {line}.ToArray());
		}
	}
}