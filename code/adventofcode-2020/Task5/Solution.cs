using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode_2020.Task5
{
    public class Solution
    {
        /// <summary>
        /// Solution for the first https://adventofcode.com/2020/day/3/ task
        /// </summary>
        public static int Function(List<string> input)
        {
            var treesCount = 0;
            var skip = 3;
            var data = input.Skip(1).ToList();
            foreach (var line in data)
            {
                if (skip >= line.Length)
                {
                    skip = skip - line.Length;
                }

                if (line.Skip(skip).Take(1).First() == '#')
                {
                    treesCount++;
                }
                skip += 3;
            }

            return treesCount;
        }
    }
}
