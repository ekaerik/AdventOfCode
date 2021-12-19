using System.Collections.Generic;
using System.Linq;

namespace _2018
{
	public class Day1
	{
		public int Part1(IEnumerable<string> inputs) => inputs.Sum(int.Parse);

		public int Part2(string[] inputs)
		{
			var sum = 0;
			var results = new List<int>(){0};
			while (results.Distinct().Count() == results.Count())
			{
				foreach (var input in inputs)
				{
					sum += int.Parse(input);
					if (results.Contains(sum))
						return sum;
					results.Add(sum);
				}
			}
			return sum;
		}
		
		
	}
}
