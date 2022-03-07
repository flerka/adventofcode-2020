using adventofcode_2020.Task6;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace adventofcode_2020.Tests.Task6
{
    public class SolutionTests
    {
        [Fact]
        public void Task6_RealExample_Correct()
        {
            Assert.Equal(336UL, Solution.Function(ReadFileAsync(Path.Combine("Task6", "Data.txt")).ToList()));
        }

        private IEnumerable<string> ReadFileAsync(string fileName)
        {
            foreach (var line in File.ReadLines(fileName))
            {
                yield return line;
            }
        }
    }
}
