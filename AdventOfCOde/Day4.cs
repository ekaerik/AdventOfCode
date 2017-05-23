using MoreLinq;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCOde
{
	public class Day4
	{
		private RoomParser roomParser;

		public Day4()
		{
			roomParser = new RoomParser();
		}

		public int SectorIdSumForRealRooms(params string[] rooms)
		{
			var result = 0;
			foreach (var room in rooms)
			{
				(var encryption, var sectorId, var checksum) = roomParser.Parse(room);
				
				var chars = encryption.ToCharArray().Where(c => c != '-');
				var orderByOccuranceAndAlphabetIfTied = chars
					.GroupBy(c => c)
					.OrderByDescending(g => g.Count())
					.ThenBy(g => g.Key);
				var charsToMatch = orderByOccuranceAndAlphabetIfTied
					.Take(5)
					.Select(x => x.Key)
					.ToArray();

				var valid = true;
				for(var i = 0; i < charsToMatch.Length; i++)
				{
					if (charsToMatch[i] != checksum[i])
					{
						valid = false;
						break;
					}
				}

				result += valid ? sectorId : 0;

			}
			return result;
		}

		private class RoomParser
		{
			private Regex regex = new Regex(@"(.*?)(\d*?)\[(.*?)\]");

			public (string encryption, int sectorId, string checksum) Parse(string encryptedRooms)
			{
				var match = regex.Match(encryptedRooms);
				return (match.Groups[1].Value, int.Parse(match.Groups[2].Value), match.Groups[3].Value);
			}
		}
	}
}
