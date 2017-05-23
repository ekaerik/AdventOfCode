using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCOde
{
	public class Day4
	{
		private Regex regex = new Regex(@"(.*?)(\d*?)\[(.*?)\]");
		
		public int SectorIdSumForRealRooms(params string[] rooms)
		{
			var result = 0;
			foreach (var room in rooms)
			{
				var matches = regex.Match(room);
				var encryption = matches.Groups[1].Value;
				var sectorId = int.Parse(matches.Groups[2].Value);
				var checksum = matches.Groups[3].Value;
				
				var letterGroups = encryption
					.ToCharArray()
					.Where(l => l != '-')
					.GroupBy(l => l)
					.OrderByDescending(g => g.Count())
					.ThenBy(g => g.Key)
					.ToArray();
				
				var valid = false;
				for (var i = 0; i < 5; i++)
				{
					if(letterGroups[i].Key != checksum[i])
					{
						valid = false;
						break;
					}
					valid = true;
				}
				result = valid ? result + sectorId : result;

			}
			return result;
		}
	}

	public static class ArrayExtensions
	{
		public static T SafeNext<T>(this IEnumerable<T> source, int index)
		{
			if (index + 1 <= source.Count())
				return source.ElementAt(index + 1);
			return default(T);
		}

	}
}
