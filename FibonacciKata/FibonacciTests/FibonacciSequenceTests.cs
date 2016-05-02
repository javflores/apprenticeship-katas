using System.Linq;
using FibonacciKata;
using Xunit;

namespace FibonacciTests
{
    public class FibonacciSequenceShould
    {
        [Theory]
        [InlineData(new int[]{}, 0)]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1, 1 }, 2)]
        [InlineData(new[] { 1, 1, 2 }, 3)]
        [InlineData(new[] { 1, 1, 2, 3 }, 4)]
        [InlineData(new[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 }, 10)]
        public void contain_expected_elements(int[] expectedFibonacci, int numberOfElements)
        {
            var fibonacciSequence = new FibonacciSequence().Generate(numberOfElements);

            Assert.True(fibonacciSequence.SequenceEqual(expectedFibonacci));
        }
    }
}
