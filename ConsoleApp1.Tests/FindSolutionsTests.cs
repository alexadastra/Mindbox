using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    public class FindSolutionsTests
    {
        [Test]
        public void ReturnsDefaultSolutions()
        {
            float[] coefficients = new float[] {2, 3, 1};
            float D = 1;

            double[] solutions = Quadatic.calculateSolutions(coefficients, D);
            
            Assert.AreEqual(solutions, new double[]{-0.5, -1});
        }

        [Test]
        public void ReturnSingleSolution()
        {
            float[] coeffitients = new float[] {1, 0, 0};
            float D = 0;

            double[] solutions = Quadatic.calculateSolutions(coeffitients, D);

            var doubles = new double[] {0};
            Assert.AreEqual(solutions, doubles);
        }
        
    }
}