using System;
using Solver.Base;

namespace Solver.Challenges.Day12
{
	public class Day12Solver : ISolver<int, Day12Input>
	{
		public int Star1(Day12Input input)
		{
			var x = 0;
			var y = 0;
			var direction = 'E';
			foreach (var inputCommand in input.Commands)
				switch (inputCommand.Direction)
				{
					case 'N':
					case 'S':
					case 'W':
					case 'E':
						(x, y) = Move(x, y, inputCommand.Count, inputCommand.Direction);
						break;
					case 'F':
						(x, y) = Move(x, y, inputCommand.Count, direction);
						break;
					case 'R':
					{
						var deg = inputCommand.Count;
						while (deg > 0)
						{
							direction = direction switch
							{
								'N' => 'E',
								'E' => 'S',
								'S' => 'W',
								'W' => 'N',
								_ => throw new ArgumentOutOfRangeException()
							};
							deg -= 90;
						}
					}
						break;
					case 'L':
					{
						var deg = inputCommand.Count;
						while (deg > 0)
						{
							direction = direction switch
							{
								'N' => 'W',
								'W' => 'S',
								'S' => 'E',
								'E' => 'N',
								_ => throw new ArgumentOutOfRangeException()
							};
							deg -= 90;
						}
					}
						break;
				}

			return Math.Abs(x) + Math.Abs(y);
		}

		public int Star2(Day12Input input)
		{
			var x = 0;
			var y = 0;
			var wpX = 10;
			var wpY = -1;
			foreach (var inputCommand in input.Commands)
				switch (inputCommand.Direction)
				{
					case 'N':
					case 'S':
					case 'W':
					case 'E':
						(wpX, wpY) = Move(wpX, wpY, inputCommand.Count, inputCommand.Direction);
						break;
					case 'F':
						x += inputCommand.Count * wpX;
						y += inputCommand.Count * wpY;
						break;
					case 'R':
					{
						var deg = inputCommand.Count;
						while (deg > 0)
						{
							var tmp = wpX;
							wpX = wpY * -1;
							wpY = tmp;
							deg -= 90;
						}
					}
						break;
					case 'L':
					{
						var deg = inputCommand.Count;
						while (deg > 0)
						{
							var tmp = wpX;
							wpX = wpY;
							wpY = tmp * -1;
							deg -= 90;
						}
					}
						break;
				}

			return Math.Abs(x) + Math.Abs(y);
		}

		private (int, int) Move(int x, int y, int cnt, char direction)
		{
			switch (direction)
			{
				case 'N':
					y -= cnt;
					break;
				case 'S':
					y += cnt;
					break;
				case 'W':
					x -= cnt;
					break;
				case 'E':
					x += cnt;
					break;
			}

			return (x, y);
		}
	}
}