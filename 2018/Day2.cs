using System.Linq;

namespace _2018
{
	public class Day2
	{
		public int MultiplyChecksums(string[] inputs)
		{
			var numberOfInputsWithTwoRepeatChars = 0;
			var numberOfInputsWithThreeRepeatChars = 0;
			foreach (var input in inputs)
			{
				var charGroupings = input
					.Select(x => x)
					.GroupBy(x => x)
					.ToArray();
				numberOfInputsWithTwoRepeatChars += charGroupings.Any(x => x.Count() == 2) ? 1 : 0;
				numberOfInputsWithThreeRepeatChars += charGroupings.Any(x => x.Count() == 3) ? 1 : 0;
			}

			return numberOfInputsWithTwoRepeatChars * numberOfInputsWithThreeRepeatChars;
		}

		public string FindTheCorrectBox(string[] inputs)
		{
			return "";
		}
	}
}