namespace _2017
{
	public class Day5
	{
		public int StepsToExit(int[] steps)
		{
			var stepCounter = 0;
			var index = 0;

			do
			{
				var jumpTo = steps[index];
				steps[index]++;
				index += jumpTo;
				stepCounter++;
			} while (index <= steps.Length -1);

			return stepCounter;
		}
	}
}