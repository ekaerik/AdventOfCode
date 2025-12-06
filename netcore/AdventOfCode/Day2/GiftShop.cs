using Xunit.Abstractions;

namespace AdventOfCode.Day2;

public class GiftShop_Part1(ITestOutputHelper output)
{
    [Fact]
    public void Should_solve_part1()
    {
        var invalidIds = Input.Data
            .Split(",")
            .SelectMany(IdChecker.CheckId);
        var result = invalidIds.Sum();

        // output.WriteLine($"Number of invalid ids {string.Join(", ", invalidIds) }");
        output.WriteLine($"Sum: {result}");
    }

}

public class GiftShop_Part2(ITestOutputHelper output)
{
    [Fact]
    public void Should_solve_part2()
    {
        var invalidIds = Input.Data
            .Split(",")
            .SelectMany(IdChecker.CheckId_part2);
        var result = invalidIds.Sum();

        // output.WriteLine($"Number of invalid ids {string.Join(", ", invalidIds)}");
        output.WriteLine($"Sum: {result}");
    }
}
public static class IdChecker
{
    public static long[] CheckId(string id)
    {
        var result = new List<long>();
        foreach (var step in IdRange(id))
        {
            var half = step.Length / 2;
            var firstPart = step[..half];
            var secondPart = step[half..];
            if (firstPart == secondPart)
                result.Add(long.Parse(step));
        }

        return [.. result];
    }

    public static long[] CheckId_part2(string id)
    {
        var result = new List<long>();
        foreach (var step in IdRange(id))
        {
            for (var split = 1; split <= step.Length / 2; split++)
            {
                if (step.Length % split != 0)
                    continue;

                var parts = new List<string>();
                for (var i = split; i <= step.Length; i += split)
                {
                    var start = i - split;
                    parts.Add(step[start..i]);
                }

                var firstPart = parts[0];
                if (parts.All(x => x == firstPart))
                    result.Add(long.Parse(step));
            }
        }

        return [.. result.Distinct()];
    }

    private static string[] IdRange(string id)
    {
        var parts = id.Split("-");
        var start = long.Parse(parts[0]);
        var end = long.Parse(parts[1]);

        var range = new List<string>();
        for (var i = start; i <= end; i++)
            range.Add(i.ToString());

        return [.. range];
    }
}
