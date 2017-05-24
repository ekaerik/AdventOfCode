using AdventOfCOde;
using FluentAssertions;
using System;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCodeTest
{
	public class Day1Test
	{
		ITestOutputHelper output;

		public Day1Test(ITestOutputHelper output)
		{
			this.output = output;
		}

		[Fact]
		public void ShouldCalculate1()
		{
			var input = new[] { "R2", "L3" };
			var day1 = new Day1();

			var result = day1.Calculate(input);

			result.Coordinate.X.Should().Be(2);
			result.Coordinate.Y.Should().Be(3);
			result.Blocks.Should().Be(5);
		}

		[Fact]
		public void ShouldCalculate2()
		{
			var input = new[] { "R2", "R2", "R2" };
			var day1 = new Day1();

			var result = day1.Calculate(input);

			result.Coordinate.X.Should().Be(0);
			result.Coordinate.Y.Should().Be(-2);
			result.Blocks.Should().Be(2);
		}

		[Fact]
		public void ShouldCalculate3()
		{
			var input = new[] { "R5", "L5", "R5", "R3" };
			var day1 = new Day1();

			var result = day1.Calculate(input);

			result.Blocks.Should().Be(12);
		}

		[Fact]
		public void ShouldSolve()
		{
			var input = new[] { "R3", "L5", "R1", "R2", "L5", "R2", "R3", "L2", "L5", "R5", "L4", "L3", "R5", "L1", "R3", "R4", "R1", "L3", "R3", "L2", "L5", "L2", "R4", "R5", "R5", "L4", "L3", "L3", "R4", "R4", "R5", "L5", "L3", "R2", "R2", "L3", "L4", "L5", "R1", "R3", "L3", "R2", "L3", "R5", "L194", "L2", "L5", "R2", "R1", "R1", "L1", "L5", "L4", "R4", "R2", "R2", "L4", "L1", "R2", "R53", "R3", "L5", "R72", "R2", "L5", "R3", "L4", "R187", "L4", "L5", "L2", "R1", "R3", "R5", "L4", "L4", "R2", "R5", "L5", "L4", "L3", "R5", "L2", "R1", "R1", "R4", "L1", "R2", "L3", "R5", "L4", "R2", "L3", "R1", "L4", "R4", "L1", "L2", "R3", "L1", "L1", "R4", "R3", "L4", "R2", "R5", "L2", "L3", "L3", "L1", "R3", "R5", "R2", "R3", "R1", "R2", "L1", "L4", "L5", "L2", "R4", "R5", "L2", "R4", "R4", "L3", "R2", "R1", "L4", "R3", "L3", "L4", "L3", "L1", "R3", "L2", "R2", "L4", "L4", "L5", "R3", "R5", "R3", "L2", "R5", "L2", "L1", "L5", "L1", "R2", "R4", "L5", "R2", "L4", "L5", "L4", "L5", "L2", "L5", "L4", "R5", "R3", "R2", "R2", "L3", "R3", "L2", "L5" };
			var day1 = new Day1();

			var result = day1.Calculate(input);

			output.WriteLine($"{result.Blocks}");

			result.Blocks.Should().Be(236);
		}
	}
}
