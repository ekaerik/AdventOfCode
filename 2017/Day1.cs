using System;
using System.Linq;
using MoreLinq;

namespace _2017
{
    public class Day1
    {
        public int Calculate(string input)
        {
            var sum = 0;
            for (var i = 0; i < input.Length; i++)
            {
                var current = input[i];
                var next = i == input.Length - 1 ? input[0] : input[i + 1];
                if (current == next)
                    sum += Int32.Parse(current.ToString());
            }
            return sum;
        }
    }
}