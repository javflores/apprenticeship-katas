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
        public void contain_numbers_as_sum_of_previous_two_numbers(int[] expectedFibonacci, int numberOfElements)
        {
            var fibonacciSequence = new FibonacciSequence(numberOfElements);

            Assert.True(fibonacciSequence.SequenceEqual(expectedFibonacci));
        }
    }
}
