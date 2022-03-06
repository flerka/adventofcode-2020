using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode_2020.Task1
{
    public class Solution
    {
        /// <summary>
        /// Solution for the first https://adventofcode.com/2020/day/1/ task
        /// </summary>
        public static int Function(IEnumerable<int> input)
        {
            var h = new HashSet<int>();
            foreach (var i in input)
            {
                if (h.Contains(2020 - i))
                {
                    return i * (2020 - i);
                }

                h.Add(i);
            }

            return 0;
        }
    }
}
