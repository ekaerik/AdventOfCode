using AdventOfCOde;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCodeTest
{
	[TestFixture]
	public class Day4Test
	{
		[Test]
		public void Should1()
		{
			var result = new Day4().RealRooms("aaaaa-bbb-z-y-x-123[abxyz]");

			result.Should().Be(123);
		}

		[Test]
		public void Should2()
		{
			var result = new Day4().RealRooms("a-b-c-d-e-f-g-h-987[abcde]");

			result.Should().Be(987);
		}

		[Test]
		public void Should3()
		{
			var result = new Day4().RealRooms("not-a-real-room-404[oarel]");

			result.Should().Be(404);
		}

		[Test]
		public void Should4()
		{
			var result = new Day4().RealRooms("totally-real-room-200[decoy]");

			result.Should().Be(0);
		}
		
		[Test]
		public void ShouldCheckAlphabeticalInTie()
		{
			var result = new Day4().RealRooms("b-a-c-e-d-f-g-h-987[abcde]");

			result.Should().Be(0);
		}

		[Test]
		public void ShouldCheckCountAndTie()
		{
			var result = new Day4().RealRooms("aaa-z-b-111[abc]");

			result.Should().Be(0);
		}
	}
}
