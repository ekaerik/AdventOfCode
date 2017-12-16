using System.Collections.Generic;
using System.Linq;

namespace _2017
{
    public class Day2
    {
        public int Calcualate(IEnumerable<int[]> input)
        {
            var checksum = 0;
            foreach (var row in input)
            {
                var ordered = row.OrderBy(i => i).ToArray();
                var largestDifferenceForRow = ordered.Last() - ordered.First();
                checksum += largestDifferenceForRow;
            }
            
            return checksum;
        }
        
    }
}