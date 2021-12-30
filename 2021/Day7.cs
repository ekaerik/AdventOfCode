namespace _2021
{
    public class Day7
    {
        public int Execute(int[] example)
        {
            var start = example.Min();
            var max = example.Max();

            var result = int.MaxValue;
            for (var i = start; i <= max; i++)
            {
                var current = calculate(i, example);
                if (current < result)
                    result = current;
            }
            return result;
        }

        public int Execute2(int[] example)
        {
            var start = example.Min();
            var max = example.Max();

            var result = int.MaxValue;
            for (var i = start; i <= max; i++)
            {
                var current = example.Aggregate(0, (agg, item) =>
                {
                    var distance = item > i ? item - i : i - item;

                    agg += Enumerable.Range(1, distance).Sum();

                    return agg;
                });

                if (current < result)
                    result = current;
            }
            return result;
        }

        private int calculate(int position, int[] values)
        {
            var bigger = values.Where(x => x > position).Sum(x => x - position);
            var smaller = values.Where(x => x < position).Sum(x => position - x);
            return bigger + smaller;
        }
    }
}
