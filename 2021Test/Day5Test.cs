using _2021;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace _2021Test
{
    public class Day5Test : AdventOfCodeTest
    {
        public Day5Test(ITestOutputHelper output) : base(output)
        {
        }

        public class Part1
        {
            [Fact(Skip = "Not today")]
            public void Should()
            {
                var example = new[]
                {
                    ((0,9), (5,9)),
                    ((8,0), (0,8)),
                    ((9,4), (3,4)),
                    ((2,2), (2,1)),
                    ((7,0), (7,4)),
                    ((6,4), (2,0)),
                    ((0,9), (2,9)),
                    ((3,4), (1,4)),
                    ((0,0), (8,8)),
                    ((5,5), (8,2))
                };
                var target = new Day5();

                var result = target.Execute(example);

                result.Should().Be(5);
            }
        }
    }
}