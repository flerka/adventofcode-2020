using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode_2020.Task3
{
    public record InputData(int Min, int Max, char C, string Password);

    public class Solution
    {
        /// <summary>
        /// Solution for the first https://adventofcode.com/2020/day/2/ task
        /// </summary>
        public static int Function(IEnumerable<InputData> input)
        {
            var validCount = 0;

            foreach (var i in input)
            {
                var charDic = i.Password
                    .GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

                if (charDic.ContainsKey(i.C) && charDic[i.C] >= i.Min && charDic[i.C] <= i.Max)
                {
                    validCount++;
                }

            }

            return validCount;
        }
    }
}
