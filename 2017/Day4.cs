using System.Collections.Generic;
using System.Linq;

namespace _2017
{
	public class Day4
	{
		public int CountValid(IEnumerable<string> passphrases)
		{
			return passphrases
				.Sum(pp =>
				{
					var words = pp.Split(' ');
					if (words.GroupBy(x => x).Any(x => x.Count() > 1))
						return 0;
					return 1;
				});
		}
	}
}