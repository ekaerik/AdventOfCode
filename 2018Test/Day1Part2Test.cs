using FluentAssertions;
using Xunit;
using Xunit.Abstractions;
using _2018;

namespace _2018Test
{
	public class Day1Part2Test
	{
		private readonly ITestOutputHelper output;

		public Day1Part2Test(ITestOutputHelper output)
		{
			this.output = output;
		}

		[Fact]
		public void Example1()
		{
			var target = new Day1();

			var result = target.Part2(new[] {"+1", "-2", "+3", "+1"});

			result.Should().Be(2);
		}
		
		[Fact]
		public void Example2()
		{
			var target = new Day1();

			var result = target.Part2(new[] {"+1", "-1"});

			result.Should().Be(0);
		}
		
		[Fact]
		public void Example3()
		{
			var target = new Day1();

			var result = target.Part2(new[] {"+3", "+3", "+4", "-2", "-4"});

			result.Should().Be(10);
		}
		
		[Fact]
		public void Example4()
		{
			var target = new Day1();

			var result = target.Part2(new[] {"+7", "+7", "-2", "-7", "-4"});

			result.Should().Be(14);
		}

		[Fact]
		public void Should_solve()
		{
			var target = new Day1();

			var result = target.Part2(Day1Part1Test.Input);
			
			output.WriteLine(result.ToString());
		}
		
	}
}