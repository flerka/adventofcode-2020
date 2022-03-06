using System.Collections.Generic;
using System.Linq;

namespace adventofcode_2020.Task2
{
    public class Solution
    {
        /// <summary>
        /// Solution for the second https://adventofcode.com/2020/day/1/ task
        /// </summary>
        public static long Function(IEnumerable<int> input)
        {
            var iHashSet = input.ToHashSet();
            var mHashSet = input.Select(x => 2020 - x).ToHashSet();

            foreach (var i in input)
            {
                foreach(var h in mHashSet)
                {
                    if (iHashSet.Contains(h - i))
                    {
                        return (2020 - h) * i * (h - i);
                    }
                }
            }

            return 0;
        }
    }
}
