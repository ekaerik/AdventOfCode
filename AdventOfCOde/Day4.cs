using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCOde
{
	public class Day4
	{
		private Regex regex = new Regex(@"(.*?)(\d*?)\[(.*?)\]");
		
		public int RealRooms(params string[] rooms)
		{
			var result = 0;
			foreach (var room in rooms)
			{
				var matches = regex.Match(room);
				var encryption = matches.Groups[1].Value;
				var sectorId = int.Parse(matches.Groups[2].Value);
				var checksum = matches.Groups[3].Value;

				var groups = (from l in encryption.ToCharArray()
						   group l by l into g
						   where g.Key != '-'
						   orderby g.Count() descending
						   select g).ToArray();
				var ties = (from g in groups
							group g by g.Count() into t
							select t)
							.ToArray();

				var valid = false;
				for (var i = 0; i < 5; i++)
				{
					var next = groups.SafeNext(i);
					var tie = groups[i].Count() == next?.Count();
					if (tie)
					{
						var nextLetter = ties[i].Key + 1;
						if (checksum.SafeNext(i) != 
					}
					if (checksum[i] != groups[i].Key)
					{
						break;
					}					
					valid = true;
				}
				for (var i = 0; i < 5; i++)
				{
					
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
