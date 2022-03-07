using adventofcode_2020.Task5;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace adventofcode_2020.Tests.Task5
{
    public class SolutionTests
    {
        [Fact]
        public void Task5_RealExample_Correct()
        {
            Assert.Equal(7, Solution.Function(ReadFileAsync(Path.Combine("Task5", "Data.txt")).ToList()));
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
