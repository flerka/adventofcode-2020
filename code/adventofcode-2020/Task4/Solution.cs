using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode_2020.Task4
{
    public record InputData(int Min, int Max, char C, string Password);

    public class Solution
    {
        /// <summary>
        /// Solution for the second https://adventofcode.com/2020/day/2/ task
        /// </summary>
        public static int Function(IEnumerable<InputData> input)
        {
            var validCount = 0;

            foreach (var i in input)
            {
                if (i.Password[i.Min - 1] == i.C ^ i.Password[i.Max - 1] == i.C)
                {
                    validCount++;
                }
            }

            return validCount;
        }
    }
}
