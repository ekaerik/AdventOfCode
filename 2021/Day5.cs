namespace _2021
{
    public class Day5
    {
        public int Execute(((int x, int y) start, (int x, int y) end)[] input)
        {
            var straightLines = input
                .Where(c => c.start.x == c.end.x || c.start.y == c.end.y)
                .ToArray();

            return 0;
        }
    }
}
