using adventofcode_2020.Task1;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace adventofcode_2020.Tests.Task1
{
    public class SolutionTests
    {
        [Fact]
        public void Task1_RealExample_Correct()
        {
            Assert.Equal(514579, Solution.Function(ReadFileAsync(Path.Combine("Task1", "Data.txt"))));
        }

        private IEnumerable<int> ReadFileAsync(string fileName)
        {
            foreach (var line in File.ReadLines(fileName))
            {
                yield return int.Parse(line);
            }
        }
    }
}
