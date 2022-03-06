using adventofcode_2020.Task2;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace adventofcode_2020.Tests.Task2
{
    public class SolutionTests
    {
        [Fact]
        public void Task2_RealExample_Correct()
        {
            Assert.Equal(241861950L, Solution.Function(ReadFileAsync(Path.Combine("Task2", "Data.txt"))));
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
