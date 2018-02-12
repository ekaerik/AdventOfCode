using System;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;
using _2017;

namespace _2017Test
{
	public class Day3Test
	{
		private const string reason = "Too hard";
		private readonly ITestOutputHelper _output;

		public Day3Test(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact(Skip = reason)]
		public void Example1()
		{
			var target = new Day3();

			var result = target.CalculateDistance(1);

			result.Should().Be(1);
		}
		
		[Fact(Skip = reason)]
		public void Example2()
		{
			var target = new Day3();

			var result = target.CalculateDistance(12);

			result.Should().Be(3);
		}
		
		[Fact(Skip = reason)]
		public void Example3()
		{
			var target = new Day3();

			var result = target.CalculateDistance(23);
			
			result.Should().Be(2);
		}
	}
}