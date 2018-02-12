using FluentAssertions;
using Xunit;
using Xunit.Abstractions;
using _2017;

namespace _2017Test
{
	public class Day6Test
	{
		private readonly ITestOutputHelper _output;

		public Day6Test(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void Example1()
		{
			var target = new Day6();
			
			var result = target.CalculateCycles(new []{0, 2, 7, 0});

			result.Should().Be(5);
		}

		[Fact(Skip = "Slow")]
		public void ShouldSolve()
		{
			var target = new Day6();

			var result = target.CalculateCycles(new []{4, 10, 4, 1, 8, 4, 9, 14, 5, 1, 14, 15, 0, 15, 3, 5});
			
			_output.WriteLine(result.ToString());
		}

	}
}