using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace _2017
{
	public class Day6
	{
		public int CalculateCycles(int[] input)
		{
			var distribution = input.ToArray();
			var seenDistributions = new List<string>();
			var cycles = 0;
			bool duplicate;
			do
			{
				var current = distribution.Max();
				var index = Array.IndexOf(distribution, current);
				distribution[index] = 0;
				while (current > 0)
				{
					index = GetIndex(index, distribution);
					distribution[index]++;
					current--;
				}

				var stringified = JsonConvert.SerializeObject(distribution);
				duplicate = seenDistributions.Any(x => x == stringified);
				seenDistributions.Add(stringified);
				
				cycles++;

			} while (!duplicate);

			return cycles;
		}

		private static int GetIndex(int current, IEnumerable<int> ints)
		{
			if (current == ints.Count() - 1)
				return 0;
			return ++current;
		}
	}
}