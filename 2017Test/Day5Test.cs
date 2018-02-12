﻿using System;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;
using _2017;

namespace _2017Test
{
	public class Day5Test
	{
		private readonly ITestOutputHelper _output;

		public Day5Test(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void Example1()
		{
			var target = new Day5();

			var result = target.StepsToExit(new[] {0, 3, 0, 1, -3});

			result.Should().Be(5);
		}

		[Fact]
		public void ShouldStepEasyExample()
		{
			var target = new Day5();

			var result = target.StepsToExit(new[] {1, 1, 1});

			result.Should().Be(3);
		}

		[Fact]
		public void ShouldStepBackwards()
		{
			var target = new Day5();

			var result = target.StepsToExit(new[] {2, 3, -1, 0});

			result.Should().Be(3);
		}

		[Fact]
		public void ShouldSolve()
		{
			var target = new Day5();

			var result = target.StepsToExit(input);

			_output.WriteLine(result.ToString());
		}

		private int[] input =
		{
			2,
			2,
			1,
			2,
			-2,
			2,
			1,
			1,
			-4,
			-2,
			1,
			-3,
			-9,
			2,
			0,
			1,
			-8,
			-9,
			-12,
			2,
			-5,
			-8,
			0,
			-11,
			-3,
			-1,
			2,
			-20,
			-21,
			-18,
			-25,
			-25,
			-16,
			-18,
			-27,
			-25,
			-17,
			-13,
			-9,
			-35,
			-25,
			-1,
			-20,
			-22,
			-11,
			-3,
			-26,
			-32,
			-33,
			-21,
			-3,
			-42,
			-4,
			-48,
			-36,
			-15,
			-20,
			-29,
			-32,
			-12,
			-53,
			-32,
			0,
			-4,
			-2,
			-32,
			-55,
			-49,
			-23,
			-18,
			-34,
			-39,
			-70,
			-4,
			-64,
			-58,
			-66,
			-59,
			1,
			-36,
			-19,
			-38,
			-55,
			-25,
			-15,
			-65,
			-66,
			-65,
			-58,
			-53,
			-54,
			-18,
			-24,
			-79,
			-10,
			-73,
			-90,
			-11,
			-94,
			-79,
			-64,
			-74,
			-41,
			-85,
			-66,
			-38,
			-84,
			-46,
			-101,
			-38,
			-33,
			-107,
			-38,
			-70,
			-101,
			-7,
			-37,
			-94,
			1,
			-69,
			-42,
			-71,
			-15,
			-36,
			-70,
			-76,
			-42,
			-118,
			-39,
			-97,
			-27,
			-30,
			-6,
			-70,
			-23,
			-113,
			-103,
			-89,
			-35,
			-43,
			-11,
			-97,
			-137,
			-19,
			-6,
			-21,
			-107,
			-93,
			-50,
			-107,
			-46,
			-90,
			-51,
			-115,
			-134,
			-122,
			-88,
			-122,
			-74,
			-30,
			-10,
			-53,
			-12,
			-152,
			-68,
			-110,
			-123,
			-111,
			-40,
			-164,
			-10,
			-168,
			-38,
			-71,
			-67,
			-171,
			-146,
			1,
			-33,
			-13,
			-168,
			-106,
			-135,
			-145,
			-163,
			-125,
			-12,
			-156,
			-172,
			-69,
			0,
			-15,
			-137,
			-1,
			-21,
			0,
			-76,
			-48,
			-31,
			-86,
			-140,
			-9,
			-179,
			-45,
			-106,
			-85,
			-131,
			-180,
			-190,
			-3,
			-7,
			-89,
			-44,
			-106,
			-40,
			-171,
			-59,
			-214,
			-158,
			-160,
			-89,
			-59,
			-13,
			0,
			-215,
			-110,
			-204,
			-39,
			-171,
			-44,
			-173,
			-112,
			-153,
			-155,
			-85,
			-113,
			-226,
			-74,
			-104,
			-152,
			-5,
			-187,
			-171,
			-12,
			-165,
			-190,
			-152,
			-49,
			-177,
			-179,
			-123,
			-158,
			-131,
			-244,
			-143,
			-127,
			-124,
			-125,
			-170,
			-211,
			-201,
			-97,
			-33,
			-47,
			-243,
			-136,
			-243,
			-89,
			-192,
			-217,
			-105,
			-116,
			-268,
			-40,
			-154,
			-262,
			-223,
			-96,
			-20,
			-66,
			-239,
			-42,
			-24,
			-112,
			-162,
			-227,
			-52,
			-81,
			-80,
			-3,
			-33,
			-152,
			-33,
			-168,
			-48,
			-245,
			-87,
			-74,
			-139,
			-295,
			-17,
			-73,
			-180,
			-48,
			-182,
			-162,
			-59,
			-296,
			-37,
			-241,
			-67,
			-83,
			-218,
			-124,
			-136,
			-303,
			-38,
			-85,
			-205,
			-137,
			-14,
			-248,
			-13,
			-212,
			-266,
			-304,
			-294,
			-54,
			-145,
			-22,
			-312,
			-298,
			-23,
			-5,
			-126,
			-307,
			-190,
			-294,
			-43,
			-293,
			-339,
			-129,
			-223,
			-231,
			-59,
			-104,
			-60,
			-239,
			-11,
			-291,
			-242,
			-115,
			-117,
			-89,
			-7,
			-57,
			-280,
			-70,
			-70,
			-6,
			-35,
			-124,
			-253,
			-120,
			-322,
			-45,
			-187,
			-288,
			-237,
			-76,
			-192,
			-179,
			-269,
			-14,
			-269,
			-227,
			-374,
			-84,
			-15,
			-144,
			-266,
			-256,
			-162,
			-336,
			-266,
			-31,
			-367,
			-172,
			-156,
			-157,
			-220,
			-189,
			-152,
			-336,
			-253,
			-36,
			-324,
			-222,
			-175,
			-313,
			-289,
			-65,
			-123,
			-229,
			-204,
			-44,
			-72,
			-20,
			-78,
			-43,
			-226,
			-93,
			-399,
			-10,
			-150,
			-153,
			-221,
			-7,
			-302,
			-237,
			-288,
			-172,
			-233,
			-119,
			-247,
			-33,
			-170,
			-46,
			-424,
			-403,
			-40,
			-65,
			-116,
			-372,
			-148,
			-336,
			-287,
			-431,
			-134,
			-354,
			-14,
			-162,
			-228,
			-152,
			-119,
			-240,
			-356,
			-305,
			-15,
			-77,
			-303,
			-189,
			-205,
			-380,
			-175,
			-316,
			-396,
			-44,
			-42,
			-142,
			-363,
			-418,
			-313,
			-322,
			-307,
			-363,
			-454,
			-157,
			-308,
			-361,
			-398,
			-347,
			-249,
			-57,
			-453,
			-167,
			-194,
			-29,
			-443,
			-45,
			-359,
			-445,
			-89,
			-136,
			-60,
			-446,
			-97,
			-282,
			-298,
			-245,
			-91,
			-130,
			-423,
			-387,
			-492,
			-282,
			-415,
			-64,
			-294,
			-468,
			-251,
			-323,
			-210,
			-490,
			-142,
			-121,
			-393,
			-251,
			-265,
			-268,
			-135,
			-224,
			-116,
			-7,
			-27,
			-165,
			-265,
			-352,
			-226,
			-25,
			-327,
			-490,
			-493,
			-80,
			-501,
			-522,
			-436,
			-36,
			-464,
			-47,
			-349,
			-91,
			-460,
			-167,
			-436,
			-207,
			-41,
			-386,
			-461,
			-430,
			-412,
			-161,
			-460,
			-488,
			-207,
			-221,
			-17,
			-265,
			-115,
			-36,
			-499,
			-111,
			-518,
			-390,
			-526,
			-280,
			-150,
			-405,
			-458,
			-503,
			-527,
			-303,
			-383,
			-154,
			-317,
			-64,
			-379,
			-564,
			-385,
			-490,
			-524,
			-440,
			-69,
			-317,
			-377,
			-53,
			-503,
			-136,
			-71,
			-190,
			-19,
			-238,
			-572,
			-281,
			-294,
			-538,
			-146,
			-130,
			-406,
			-236,
			-223,
			-234,
			-16,
			-436,
			-391,
			-249,
			-508,
			-153,
			-41,
			-380,
			-229,
			-489,
			-466,
			-94,
			-596,
			-96,
			-544,
			-532,
			-106,
			-349,
			-34,
			-162,
			-6,
			-495,
			-287,
			-82,
			-307,
			-466,
			-358,
			-272,
			-282,
			-220,
			-84,
			-168,
			-124,
			-271,
			-307,
			-164,
			-627,
			-442,
			-348,
			-368,
			-548,
			-574,
			-248,
			-144,
			-516,
			-369,
			-319,
			-215,
			-476,
			-191,
			-326,
			-462,
			-286,
			-565,
			-395,
			-190,
			-353,
			-180,
			-88,
			-403,
			-520,
			-203,
			-268,
			-198,
			-374,
			-636,
			-565,
			-76,
			-447,
			-118,
			-658,
			-311,
			-468,
			-214,
			-215,
			-68,
			-370,
			-179,
			-286,
			-394,
			-532,
			-493,
			-339,
			-471,
			-344,
			-274,
			-512,
			-90,
			-306,
			-222,
			-348,
			-331,
			-670,
			-73,
			-136,
			-358,
			-518,
			-521,
			-41,
			-204,
			-476,
			-582,
			-633,
			-44,
			-133,
			-410,
			-658,
			-443,
			-158,
			-76,
			-162,
			-509,
			-150,
			-304,
			-407,
			-210,
			-667,
			-279,
			-109,
			-469,
			-680,
			-702,
			-101,
			-159,
			-197,
			-134,
			-154,
			-270,
			-90,
			-568,
			-237,
			-95,
			-328,
			-23,
			-493,
			-310,
			-649,
			-283,
			-31,
			-234,
			-126,
			-244,
			-312,
			-409,
			-84,
			-522,
			-72,
			-458,
			-190,
			-707,
			-338,
			-433,
			-709,
			-81,
			-693,
			-367,
			-302,
			-260,
			-322,
			-282,
			-379,
			-401,
			-60,
			-126,
			-645,
			-573,
			-91,
			-685,
			-312,
			-165,
			-217,
			-594,
			-386,
			-357,
			-72,
			-426,
			-354,
			-246,
			-278,
			-451,
			-37,
			-484,
			-232,
			-638,
			-569,
			-376,
			-278,
			-554,
			-666,
			-191,
			-513,
			-564,
			-502,
			-640,
			-531,
			-1,
			-667,
			-146,
			-20,
			-375,
			-771,
			-263,
			-754,
			-182,
			-190,
			-626,
			-249,
			-418,
			-278,
			-722,
			-676,
			-161,
			-666,
			-462,
			-488,
			-70,
			-569,
			-779,
			-642,
			-121,
			-556,
			-146,
			-531,
			-323,
			-116,
			-100,
			-76,
			-260,
			-339,
			-743,
			-44,
			-811,
			-137,
			-456,
			-462,
			-469,
			-500,
			-650,
			-681,
			-424,
			-336,
			-445,
			-172,
			-604,
			-776,
			-133,
			-829,
			-72,
			-88,
			-219,
			-247,
			-269,
			-205,
			-532,
			-222,
			-232,
			-201,
			-762,
			-105,
			-478,
			-263,
			-177,
			-475,
			-584,
			-439,
			-316,
			-722,
			-371,
			-35,
			-132,
			-417,
			-385,
			-695,
			-76,
			-452,
			-201,
			-848,
			-359,
			-731,
			-721,
			-211,
			-698,
			-502,
			-113,
			-271,
			-31,
			-66,
			-588,
			-794,
			-189,
			-417,
			-715,
			-96,
			-95,
			-691,
			-587,
			-193,
			-788,
			-445,
			-761,
			-347,
			-696,
			-34,
			-14,
			-358,
			-633,
			-152,
			-140,
			-371,
			-795,
			-500,
			-477,
			-617,
			-83,
			-462,
			-338,
			-167,
			-345,
			-99,
			-806,
			-798,
			-447,
			-338,
			-263,
			-76,
			-382,
			-913,
			-577,
			-657,
			-69,
			-344,
			-853,
			-679,
			-204,
			-560,
			-238,
			-455,
			1,
			-1,
			-163,
			-536,
			-344,
			-386,
			-600,
			-915,
			-245,
			-717,
			-914,
			-192,
			-931,
			-31,
			-230,
			-42,
			-531,
			-122,
			-66,
			-347,
			-476,
			-3,
			-506,
			-396,
			-839,
			-365,
			-12,
			-453,
			-247,
			-448,
			-369,
			-661,
			-451,
			-175,
			-64,
			-805,
			-63,
			-597,
			-451,
			-350,
			-77,
			-958,
			-525,
			-194,
			-116,
			-398,
			-100,
			-687,
			-758,
			-162,
			-424,
			-920,
			-162,
			-577,
			-549,
			-250,
			-594,
			-853,
			-44,
			-34,
			-882,
			-656,
			-358,
			-425,
			-592,
			-257,
			-963,
			-295,
			-561,
			-970,
			-885,
			-968,
			-112,
			-111,
			-734,
			-375,
			-825,
			-462,
			-333,
			-154,
			-490,
			-1004,
			-391,
			-925,
			-175,
			-299,
			-985,
			-432,
			-165,
			-721,
			-289,
			-817,
			-393,
			-831,
			-697,
			-599,
			-145,
			-977,
			-550,
			-577,
			-249,
			-743,
			-711,
			-4,
			-442,
			-252,
			-897,
			-130,
			-528,
			-906,
			-809,
			-228,
			-548,
			-695,
			-912,
			-676,
			-936,
			-209,
			-312,
			-951,
			-671,
			-898,
			-205,
			-730,
			-873,
			-798,
			-943
		};
	}
}