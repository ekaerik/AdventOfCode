using _2021;
using FluentAssertions;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace _2021Test
{
    public class Day6Test : AdventOfCodeTest
    {
        protected Day6 target;

        public Day6Test(ITestOutputHelper output) : base(output)
        {
            target = new Day6();
        }

        public class Part1 : Day6Test
        {
            public Part1(ITestOutputHelper output) : base(output)
            {
            }

            [Fact]
            public void Should_count_down_one_tick_per_day()
            {
                var lanternFishes = new[] { 2 };

                var result = target.Execute(1, lanternFishes);

                result.Single().Should().Be(1);
            }

            [Fact]
            public void Should_create_new_fish_after_reaching_zero()
            {
                var lanternFishes = new[] { 0, };

                var result = target.Execute(1, lanternFishes);

                result.Count().Should().Be(2);
                result.Should().Contain(8);
            }

            [Fact]
            public void Shoul_reset_counter_after_reaching_zero()
            {
                var lanternFishes = new[] { 0, };

                var result = target.Execute(1, lanternFishes);

                result.Count().Should().Be(2);
                result.Should().Contain(6);
            }


            [Fact]
            public void Should_solve_example_short()
            {
                var lanternFishes = new[] { 3, 4, 3, 1, 2 };

                var result = target.Execute(4, lanternFishes);

                result.Should().BeEquivalentTo(new[] { 6, 0, 6, 4, 5, 6, 7, 8, 8 });
            }

            [Fact]
            public void Should_solve_example()
            {
                var lanternFishes = new[] { 3, 4, 3, 1, 2 };

                var result = target.Execute(18, lanternFishes);

                result.Count().Should().Be(26);
                result.Should().BeEquivalentTo(new[] { 6, 0, 6, 4, 5, 6, 0, 1, 1, 2, 6, 0, 1, 1, 1, 2, 2, 3, 3, 4, 6, 7, 8, 8, 8, 8 });
            }

            [Fact]
            public void Should_solve_example_without_fishes()
            {
                var lanternFishes = new[] { 3, 4, 3, 1, 2 };

                var result = target.Execute(18, lanternFishes, false);

                result.Single().Should().Be(26);
            }

            [Fact]
            public void Should_solve_example2()
            {
                var lanternFishes = new[] { 3, 4, 3, 1, 2 };

                var result = target.Execute(80, lanternFishes);

                result.Count().Should().Be(5934);
            }

            [Fact]
            public void Should_solve()
            {
                var result = target.Execute(days, lanternFishes);

                output.WriteLine(result.Length.ToString());
            }

            [Fact]
            public void Should_solve_part2()
            {
                var result = target.Execute(256, lanternFishes, false);

                output.WriteLine(result.Single().ToString());
            }
        }

        private int days = 80;
        private int[] lanternFishes = new[]
        {
            4,1,1,4,1,1,1,1,1,1,1,1,3,4,1,1,1,3,1,3,1,1,1,1,1,1,1,1,1,3,1,3,1,1,1,5,1,2,1,1,5,3,4,2,1,1,4,1,1,5,1,1,5,5,1,1,5,2,1,4,1,2,1,4,5,4,1,1,1,1,3,1,1,1,4,3,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,5,1,1,2,1,1,1,1,1,1,1,2,4,4,1,1,3,1,3,2,4,3,1,1,1,1,1,2,1,1,1,1,2,5,1,1,1,1,2,1,1,1,1,1,1,1,2,1,1,4,1,5,1,3,1,1,1,1,1,5,1,1,1,3,1,2,1,2,1,3,4,5,1,1,1,1,1,1,5,1,1,1,1,1,1,1,1,3,1,1,3,1,1,4,1,1,1,1,1,2,1,1,1,1,3,2,1,1,1,4,2,1,1,1,4,1,1,2,3,1,4,1,5,1,1,1,2,1,5,3,3,3,1,5,3,1,1,1,1,1,1,1,1,4,5,3,1,1,5,1,1,1,4,1,1,5,1,2,3,4,2,1,5,2,1,2,5,1,1,1,1,4,1,2,1,1,1,2,5,1,1,5,1,1,1,3,2,4,1,3,1,1,2,1,5,1,3,4,4,2,2,1,1,1,1,5,1,5,2
        };
    }
}