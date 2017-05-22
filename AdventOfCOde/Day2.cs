using System;
using System.Collections.Generic;

namespace AdventOfCOde
{
	public class Day2
	{
		private int[][] numberpad =
			new[] {
				new[] { 1, 2, 3 },
				new[] { 4, 5, 6 },
				new[] { 7, 8, 9 }
			};


		public int Calculate(IEnumerable<string> directions, int x = 1, int y = 1)
		{
			var i = 0;
			var current = new Coordinate(x, y);
			foreach (var direction in directions)
			{
				if (direction == "U")
					current.Up();
				else if (direction == "R")
					current.Right();
				else if (direction == "D")
					current.Down();
				else if (direction == "L")
					current.Left();
				else
					throw new ArgumentException();
				i++;
			}
			return numberpad[current.Y][current.X];
		}

		private class Coordinate
		{
			public int X { get; private set; }
			public int Y { get; private set; }

			public Coordinate(int X, int Y)
			{
				this.X = X;
				this.Y = Y;
			}

			public void Up()
			{	
				Y = Y - 1 < 0 ? 0 : Y - 1;
			}
			
			public void Right()
			{
				X = X + 1 > 2 ? 2 : X + 1;
			}

			public void Down()
			{
				Y = Y + 1 > 2 ? 2 : Y + 1;
			}

			public void Left()
			{
				X = X - 1 < 0 ? 0 : X - 1;
			}
		}
	}
}
