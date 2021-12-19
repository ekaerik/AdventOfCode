namespace _2021
{

    public class Day1
    {
        public int Execute(int[] input)
        {
            var numberOfIncrease = 0;
            var previous = -1;
            foreach (var item in input)
            {
                if (previous == -1)
                    previous = item;

                if (item > previous)
                    numberOfIncrease++;

                previous = item;
            }

            return numberOfIncrease;
        }

        public int Execute2(int[] input)
        {
            var slidingWindow = new Queue<int>(3);
            var numberOfIncreases = 0;
            var previousSum = -1;
            foreach (var item in input)
            {
                if (slidingWindow.Count < 3)
                {
                    slidingWindow.Enqueue(item);
                    previousSum = slidingWindow.Sum();
                    continue;
                }

                if (slidingWindow.Count == 3)
                {
                    slidingWindow.Dequeue();
                    slidingWindow.Enqueue(item);
                }

                var currentSum = slidingWindow.Sum();
                if (currentSum > previousSum)
                    numberOfIncreases++;
                
                previousSum = currentSum;
            }


            return numberOfIncreases;
        }
    }
}
