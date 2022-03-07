using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode_2020.Task6
{
    public class Solution
    {
        /// <summary>
        /// Solution for the second https://adventofcode.com/2020/day/3/ task
        /// </summary>
        public static ulong Function(List<string> input)
        {
            return
                GetTreesCount(input, 1) *
                GetTreesCount(input, 3) *
                GetTreesCount(input, 5) *
                GetTreesCount(input, 7) *
                GetTreesCount(input, 1, 2);
        }

        private static ulong GetTreesCount(List<string> input, int stepR, int stepD = 1)
        {
            var treesCount = 0UL;
            var skipRight = stepR;
            var skipDown = stepD;

            while (skipDown < input.Count)
            {
                var line = input.Skip(skipDown).Take(1).First();

                if (skipRight >= line.Length)
                {
                    skipRight = skipRight - line.Length;
                }

                if (line.Skip(skipRight).Take(1).First() == '#')
                {
                    treesCount++;
                }

                skipRight += stepR;
                skipDown += stepD;
            }

            return treesCount;
        }
    }
}
