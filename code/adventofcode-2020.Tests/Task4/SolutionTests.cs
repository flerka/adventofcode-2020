using adventofcode_2020.Task4;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace adventofcode_2020.Tests.Task4
{
    public class SolutionTests
    {
        [Fact]
        public void Task4_RealExample_Correct()
        {
            Assert.Equal(1, Solution.Function(ReadFileAsync(Path.Combine("Task4", "Data.txt"))));
        }

        private IEnumerable<InputData> ReadFileAsync(string fileName)
        {
            foreach (var line in File.ReadLines(fileName))
            {
                var i = line.Split(' ').ToList();
                yield return
                    new InputData(
                        int.Parse(i[0].Split('-').ToList()[0]),
                        int.Parse(i[0].Split('-').ToList()[1]),
                        i[1][0],
                        i[2]);
            }
        }
    }
}
