using System.Collections.Generic;

namespace AdventOfCOde
{
	public class Day3
	{
		public int NumberOfTriangles(IEnumerable<int[]> examples)
		{
			var validTriangles = 0;

			foreach(var example in examples)
			{
				if (example[1] + example[2] > example[0] &&
					example[0] + example[2] > example[1] &&
					example[0] + example[1] > example[2] )
					validTriangles++;
			}

			return validTriangles;
		}
	}
}
