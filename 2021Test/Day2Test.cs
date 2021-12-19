﻿using _2021;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace _2021Test
{

    public class Day2Test : AdventOfCodeTest
    {
        public Day2Test(ITestOutputHelper output) : base(output) { }

        public class Part1 : Day2Test
        {
            public Part1(ITestOutputHelper output) : base(output) { }

            [Fact]
            public void Should_move_forward()
            {
                var intput = new[] { "forward 5" };
                var target = new Day2();

                var result = target.Execute(intput);

                result.Horizontal.Should().Be(5);
            }

            [Fact]
            public void Should_increase_horizontal_position()
            {
                var intput = new[] { "forward 5", "forward 8" };
                var target = new Day2();

                var result = target.Execute(intput);

                result.Horizontal.Should().Be(13);
            }

            [Fact]
            public void Should_increase_depth()
            {
                var intput = new[] { "down 5" };
                var target = new Day2();

                var result = target.Execute(intput);

                result.Depth.Should().Be(5);
            }

            [Fact]
            public void Should_calculate_depth()
            {
                var intput = new[] { "down 5", "up 3", "down 1" };
                var target = new Day2();

                var result = target.Execute(intput);

                result.Depth.Should().Be(3);
            }

            [Fact]
            public void Should_solve()
            {
                var target = new Day2();

                var result = target.Execute(input);

                output.WriteLine(result.Result.ToString());
            }
        }

        public class Part2 : Day2Test
        {
            public Part2(ITestOutputHelper output) : base(output) { }

            [Fact]
            public void Should_calculate_depth_with_aim()
            {
                var input = new[] {
                    "forward 5",
                    "down 5",
                    "forward 8",
                    "up 3",
                    "down 8",
                    "forward 2"
                };
                var target = new Day2();

                var result = target.Execute2(input);

                result.Depth.Should().Be(60);
                result.Horizontal.Should().Be(15);
            }

            [Fact]
            public void Should_solve()
            {
                var target = new Day2();

                var result = target.Execute2(input);

                output.WriteLine(result.Result.ToString());
            }
        }

        protected string[] input = new[]
        {
            "forward 2",
            "forward 3",
            "forward 5",
            "forward 6",
            "down 7",
            "forward 8",
            "forward 4",
            "forward 7",
            "forward 5",
            "forward 5",
            "down 4",
            "down 9",
            "forward 8",
            "forward 5",
            "up 5",
            "down 5",
            "forward 3",
            "down 4",
            "down 8",
            "forward 9",
            "down 1",
            "up 9",
            "down 7",
            "up 7",
            "up 1",
            "forward 1",
            "down 1",
            "down 4",
            "down 4",
            "down 8",
            "down 4",
            "up 3",
            "down 1",
            "down 3",
            "forward 7",
            "down 6",
            "forward 3",
            "forward 5",
            "forward 2",
            "up 9",
            "forward 7",
            "up 5",
            "down 3",
            "forward 1",
            "forward 2",
            "down 3",
            "down 8",
            "down 3",
            "forward 8",
            "up 5",
            "down 5",
            "forward 3",
            "down 5",
            "forward 9",
            "down 3",
            "down 4",
            "down 9",
            "down 7",
            "up 3",
            "down 9",
            "up 9",
            "up 1",
            "forward 3",
            "up 4",
            "down 3",
            "forward 7",
            "forward 7",
            "up 7",
            "forward 6",
            "down 7",
            "down 6",
            "forward 2",
            "forward 9",
            "down 5",
            "forward 4",
            "up 6",
            "down 1",
            "down 9",
            "down 9",
            "forward 4",
            "down 1",
            "forward 6",
            "down 1",
            "down 5",
            "down 4",
            "down 4",
            "forward 4",
            "forward 9",
            "up 1",
            "down 2",
            "down 8",
            "down 5",
            "down 8",
            "down 8",
            "up 2",
            "forward 8",
            "up 1",
            "forward 4",
            "down 5",
            "down 1",
            "up 2",
            "forward 6",
            "forward 9",
            "forward 2",
            "forward 6",
            "forward 9",
            "up 6",
            "forward 9",
            "up 4",
            "down 7",
            "up 6",
            "forward 2",
            "down 1",
            "up 3",
            "forward 1",
            "forward 8",
            "down 6",
            "down 8",
            "down 8",
            "forward 8",
            "forward 2",
            "forward 2",
            "down 2",
            "up 1",
            "down 9",
            "up 9",
            "down 9",
            "up 3",
            "forward 9",
            "up 4",
            "up 7",
            "up 6",
            "down 9",
            "forward 1",
            "down 3",
            "down 4",
            "forward 8",
            "down 3",
            "down 9",
            "up 3",
            "forward 2",
            "up 5",
            "down 3",
            "forward 8",
            "up 3",
            "down 3",
            "forward 2",
            "forward 9",
            "down 1",
            "down 9",
            "down 4",
            "up 7",
            "down 4",
            "up 6",
            "forward 5",
            "down 6",
            "forward 3",
            "down 2",
            "forward 1",
            "forward 8",
            "down 4",
            "forward 1",
            "up 7",
            "forward 6",
            "up 9",
            "forward 6",
            "down 3",
            "forward 2",
            "down 4",
            "forward 6",
            "down 3",
            "down 6",
            "down 1",
            "down 1",
            "down 5",
            "forward 3",
            "forward 9",
            "forward 8",
            "down 3",
            "forward 7",
            "up 9",
            "forward 9",
            "up 2",
            "forward 4",
            "up 3",
            "forward 1",
            "up 6",
            "up 8",
            "down 5",
            "down 6",
            "up 9",
            "down 6",
            "down 9",
            "up 9",
            "down 4",
            "forward 5",
            "up 2",
            "down 3",
            "up 3",
            "down 1",
            "forward 3",
            "down 5",
            "forward 7",
            "down 6",
            "down 7",
            "down 5",
            "forward 2",
            "up 6",
            "down 9",
            "down 4",
            "down 3",
            "forward 9",
            "up 8",
            "forward 2",
            "down 2",
            "forward 4",
            "up 6",
            "down 4",
            "up 8",
            "down 7",
            "down 2",
            "up 6",
            "up 4",
            "down 2",
            "forward 5",
            "up 4",
            "down 8",
            "forward 3",
            "forward 1",
            "down 7",
            "forward 8",
            "forward 7",
            "down 7",
            "up 4",
            "forward 8",
            "down 5",
            "up 9",
            "forward 1",
            "forward 4",
            "forward 9",
            "forward 7",
            "down 9",
            "up 9",
            "down 1",
            "down 7",
            "forward 7",
            "down 7",
            "down 7",
            "down 3",
            "down 5",
            "forward 3",
            "down 2",
            "forward 6",
            "down 9",
            "up 5",
            "up 3",
            "forward 5",
            "down 6",
            "down 1",
            "forward 4",
            "down 3",
            "forward 8",
            "down 7",
            "forward 7",
            "forward 7",
            "up 7",
            "up 2",
            "up 3",
            "forward 9",
            "down 5",
            "up 2",
            "forward 5",
            "up 5",
            "forward 2",
            "forward 2",
            "down 8",
            "forward 2",
            "up 4",
            "forward 1",
            "forward 3",
            "up 8",
            "up 9",
            "forward 5",
            "down 1",
            "up 8",
            "down 4",
            "down 8",
            "up 4",
            "forward 9",
            "down 6",
            "down 8",
            "up 2",
            "up 3",
            "down 7",
            "down 4",
            "forward 5",
            "down 6",
            "forward 3",
            "forward 3",
            "forward 8",
            "down 1",
            "down 7",
            "down 9",
            "down 2",
            "down 7",
            "forward 7",
            "down 7",
            "down 6",
            "up 6",
            "forward 8",
            "forward 5",
            "up 5",
            "down 2",
            "up 8",
            "up 4",
            "down 9",
            "up 2",
            "forward 5",
            "up 2",
            "down 4",
            "up 4",
            "forward 2",
            "forward 4",
            "forward 9",
            "forward 9",
            "up 4",
            "up 5",
            "down 1",
            "down 6",
            "down 1",
            "down 4",
            "down 5",
            "down 3",
            "forward 3",
            "down 9",
            "forward 6",
            "down 3",
            "down 9",
            "down 2",
            "up 2",
            "down 2",
            "down 7",
            "forward 9",
            "down 3",
            "down 3",
            "down 2",
            "down 3",
            "forward 2",
            "down 9",
            "down 9",
            "up 5",
            "up 3",
            "forward 4",
            "up 7",
            "forward 8",
            "up 6",
            "forward 7",
            "down 7",
            "down 1",
            "forward 5",
            "down 2",
            "up 1",
            "down 8",
            "up 3",
            "forward 2",
            "up 9",
            "down 1",
            "down 3",
            "down 6",
            "down 2",
            "down 7",
            "up 2",
            "forward 5",
            "forward 7",
            "down 2",
            "forward 5",
            "forward 4",
            "forward 5",
            "down 3",
            "forward 7",
            "down 7",
            "forward 8",
            "down 3",
            "down 2",
            "up 1",
            "forward 6",
            "down 4",
            "down 2",
            "forward 7",
            "up 3",
            "down 4",
            "forward 2",
            "up 6",
            "down 3",
            "up 6",
            "up 8",
            "down 9",
            "up 6",
            "forward 8",
            "forward 9",
            "forward 4",
            "forward 7",
            "down 2",
            "forward 9",
            "down 7",
            "up 9",
            "down 5",
            "down 6",
            "up 5",
            "down 4",
            "forward 8",
            "forward 4",
            "forward 4",
            "down 6",
            "forward 3",
            "forward 6",
            "down 9",
            "down 9",
            "up 2",
            "forward 7",
            "down 8",
            "down 9",
            "down 9",
            "forward 7",
            "forward 3",
            "down 7",
            "down 8",
            "forward 8",
            "down 6",
            "down 5",
            "down 9",
            "down 3",
            "forward 1",
            "down 5",
            "forward 2",
            "forward 8",
            "down 2",
            "forward 6",
            "forward 3",
            "down 7",
            "down 4",
            "forward 8",
            "forward 1",
            "down 6",
            "forward 9",
            "forward 6",
            "up 1",
            "up 3",
            "down 8",
            "forward 1",
            "up 5",
            "down 4",
            "forward 7",
            "up 3",
            "down 2",
            "forward 1",
            "forward 9",
            "down 9",
            "down 7",
            "forward 8",
            "down 4",
            "up 3",
            "down 4",
            "forward 2",
            "forward 6",
            "down 7",
            "forward 6",
            "down 6",
            "down 4",
            "down 1",
            "up 9",
            "down 4",
            "down 7",
            "up 4",
            "down 9",
            "forward 6",
            "down 3",
            "forward 2",
            "down 4",
            "forward 3",
            "down 5",
            "up 9",
            "forward 8",
            "up 7",
            "up 6",
            "up 4",
            "forward 1",
            "down 1",
            "forward 4",
            "up 6",
            "forward 5",
            "forward 4",
            "forward 5",
            "up 6",
            "down 1",
            "forward 3",
            "up 7",
            "down 9",
            "up 9",
            "down 5",
            "forward 6",
            "forward 4",
            "up 1",
            "down 4",
            "up 1",
            "forward 3",
            "forward 1",
            "down 3",
            "forward 7",
            "down 2",
            "forward 3",
            "up 2",
            "forward 8",
            "down 3",
            "up 9",
            "down 5",
            "forward 6",
            "down 1",
            "down 8",
            "down 5",
            "forward 1",
            "down 6",
            "up 2",
            "forward 6",
            "down 2",
            "down 1",
            "up 6",
            "up 7",
            "down 5",
            "forward 7",
            "forward 6",
            "forward 6",
            "down 7",
            "forward 4",
            "down 5",
            "up 5",
            "down 1",
            "up 8",
            "down 8",
            "down 2",
            "down 2",
            "down 9",
            "up 9",
            "forward 2",
            "forward 7",
            "down 7",
            "down 4",
            "down 4",
            "down 8",
            "forward 5",
            "forward 2",
            "up 9",
            "down 9",
            "forward 7",
            "up 9",
            "down 2",
            "down 7",
            "up 2",
            "up 8",
            "forward 8",
            "down 4",
            "forward 3",
            "forward 4",
            "forward 6",
            "forward 2",
            "down 1",
            "down 2",
            "forward 2",
            "up 1",
            "down 1",
            "forward 5",
            "up 3",
            "up 3",
            "down 3",
            "down 1",
            "down 4",
            "up 5",
            "up 6",
            "forward 5",
            "up 7",
            "forward 6",
            "down 4",
            "down 7",
            "up 8",
            "forward 1",
            "down 5",
            "up 4",
            "up 3",
            "up 5",
            "down 1",
            "up 5",
            "forward 3",
            "up 5",
            "forward 2",
            "forward 2",
            "forward 5",
            "forward 2",
            "up 9",
            "forward 4",
            "down 1",
            "down 3",
            "down 5",
            "up 2",
            "down 8",
            "forward 8",
            "forward 9",
            "down 1",
            "down 3",
            "forward 8",
            "forward 2",
            "down 2",
            "down 1",
            "up 7",
            "forward 2",
            "forward 8",
            "down 9",
            "forward 1",
            "forward 4",
            "down 7",
            "down 4",
            "up 7",
            "down 3",
            "down 1",
            "down 4",
            "up 7",
            "down 6",
            "forward 7",
            "down 8",
            "up 2",
            "up 4",
            "up 6",
            "down 9",
            "down 9",
            "down 8",
            "forward 6",
            "up 3",
            "up 1",
            "forward 9",
            "forward 6",
            "up 4",
            "up 2",
            "up 7",
            "forward 5",
            "up 9",
            "up 9",
            "forward 9",
            "up 6",
            "down 1",
            "down 3",
            "forward 3",
            "down 2",
            "down 2",
            "down 6",
            "down 9",
            "forward 3",
            "forward 7",
            "up 3",
            "forward 3",
            "down 5",
            "forward 9",
            "up 6",
            "down 2",
            "forward 8",
            "down 3",
            "up 5",
            "down 6",
            "forward 9",
            "down 5",
            "down 2",
            "down 6",
            "forward 8",
            "forward 6",
            "down 1",
            "forward 6",
            "up 1",
            "up 7",
            "down 4",
            "down 7",
            "forward 4",
            "forward 7",
            "down 4",
            "forward 8",
            "down 8",
            "down 7",
            "forward 9",
            "down 1",
            "down 3",
            "down 6",
            "forward 7",
            "forward 6",
            "forward 3",
            "forward 8",
            "down 5",
            "down 3",
            "up 1",
            "down 9",
            "down 8",
            "forward 3",
            "down 6",
            "down 1",
            "forward 5",
            "forward 5",
            "forward 9",
            "up 5",
            "down 6",
            "up 9",
            "down 7",
            "down 6",
            "up 1",
            "forward 5",
            "forward 7",
            "forward 8",
            "forward 7",
            "forward 6",
            "forward 3",
            "forward 1",
            "forward 2",
            "up 4",
            "forward 3",
            "forward 4",
            "forward 5",
            "up 2",
            "up 3",
            "forward 4",
            "down 9",
            "up 4",
            "forward 7",
            "down 6",
            "down 6",
            "down 1",
            "forward 2",
            "down 2",
            "forward 2",
            "down 3",
            "forward 7",
            "forward 8",
            "down 4",
            "up 7",
            "forward 7",
            "down 7",
            "forward 7",
            "forward 9",
            "down 7",
            "up 2",
            "down 3",
            "forward 7",
            "down 1",
            "forward 8",
            "forward 2",
            "up 9",
            "down 3",
            "forward 2",
            "up 4",
            "forward 9",
            "down 4",
            "down 4",
            "forward 4",
            "down 2",
            "down 9",
            "forward 4",
            "down 2",
            "down 6",
            "forward 9",
            "forward 2",
            "up 1",
            "forward 2",
            "forward 3",
            "down 5",
            "up 8",
            "down 4",
            "down 4",
            "forward 7",
            "down 2",
            "up 6",
            "down 9",
            "forward 9",
            "up 1",
            "forward 3",
            "down 5",
            "forward 3",
            "down 3",
            "forward 4",
            "up 3",
            "down 6",
            "down 7",
            "down 4",
            "down 8",
            "down 4",
            "down 5",
            "up 9",
            "up 1",
            "down 7",
            "up 3",
            "up 3",
            "down 3",
            "up 4",
            "up 6",
            "forward 8",
            "down 1",
            "forward 7",
            "forward 4",
            "down 9",
            "down 1",
            "forward 7",
            "forward 9",
            "forward 1",
            "down 3",
            "down 2",
            "forward 3",
            "forward 2",
            "down 7",
            "forward 9",
            "forward 6",
            "up 9",
            "down 2",
            "forward 9",
            "up 6",
            "forward 8",
            "up 1",
            "down 5",
            "down 8",
            "forward 1",
            "down 1",
            "forward 9",
            "up 1",
            "forward 9",
            "forward 1",
            "forward 1",
            "down 7",
            "forward 3",
            "forward 6",
            "down 5",
            "forward 7",
            "forward 1",
            "down 7",
            "down 6",
            "down 6",
            "forward 5",
            "up 6",
            "down 6",
            "forward 8",
            "up 2",
            "down 8",
            "down 3",
            "up 5",
            "up 8",
            "down 6",
            "forward 4",
            "forward 2",
            "up 3",
            "forward 5",
            "forward 3",
            "up 8",
            "forward 6",
            "up 8",
            "forward 1",
            "up 8",
            "up 7",
            "up 6",
            "forward 2",
            "down 9",
            "down 9",
            "forward 3",
            "down 7",
            "forward 3",
            "down 6",
            "forward 9",
            "up 5",
            "down 1",
            "forward 7",
            "down 1",
            "down 5",
            "down 9",
            "forward 8",
            "forward 9",
            "forward 7",
            "down 9",
            "up 4",
            "forward 5",
            "down 5",
            "forward 5",
            "down 9",
            "forward 9",
            "forward 3",
            "up 5",
            "forward 8",
            "up 5",
            "down 1",
            "forward 8",
            "down 3",
            "forward 6",
            "up 9",
            "forward 8",
            "down 4",
            "forward 3",
            "down 5",
            "forward 8",
            "forward 9",
            "forward 2",
            "down 1",
            "down 6",
            "down 4",
            "forward 9",
            "up 2",
            "down 3",
            "down 6",
            "down 3",
            "down 9",
            "down 1",
            "up 6",
            "down 2",
            "down 7",
            "up 5",
            "forward 5",
            "up 1",
            "down 7",
            "forward 6",
            "up 6",
            "down 2",
            "down 3",
            "forward 3",
            "down 5",
            "forward 8",
            "down 9",
            "down 7",
            "down 8",
            "up 7",
            "down 1",
            "forward 1",
            "forward 1",
            "down 2",
            "up 4",
            "forward 2",
            "down 3",
            "up 2",
            "down 3",
            "down 2",
            "forward 7",
            "down 1",
            "up 7",
            "down 2",
            "down 1",
            "forward 6",
            "down 9",
            "up 9",
            "down 4",
            "down 6",
            "up 9",
            "forward 7",
            "forward 9",
            "forward 7",
            "down 4",
            "down 1",
            "forward 7",
            "down 4",
            "down 7",
            "down 3",
            "down 5",
            "forward 3",
            "down 8",
            "forward 8",
            "forward 7",
            "forward 8",
            "down 4",
            "down 9",
            "forward 2",
            "forward 7",
            "up 8",
            "forward 4",
            "down 6",
            "up 8",
            "down 2",
            "forward 3",
            "down 6",
            "down 8",
            "forward 8",
            "forward 2",
            "forward 9",
            "up 6",
            "forward 7",
            "down 3",
            "down 5",
            "forward 8",
            "forward 9",
            "down 3",
            "forward 3",
            "forward 2",
            "forward 3",
            "down 8",
            "up 9",
            "up 5",
            "up 2",
            "up 6",
            "up 1",
            "up 1",
            "up 5",
            "forward 3",
            "forward 2",
            "down 3",
            "forward 4"
        };
    }
}