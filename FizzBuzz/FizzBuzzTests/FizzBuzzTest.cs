using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzTest
    {

        [Theory]
        [InlineData("1", 1)]
        [InlineData("1 2", 2)]
        [InlineData("1 2 Fizz", 3)]
        [InlineData("1 2 Fizz 4", 4)]
        [InlineData("1 2 Fizz 4 Buzz", 5)]
        [InlineData("1 2 Fizz 4 Buzz Fizz", 6)]
        [InlineData("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz", 10)]
        [InlineData("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz", 15)]
        [InlineData("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz", 30)]
        public void FizzBuzz_sequence_for_given_number_of_elements(string expectedFizzBuzz, int numberOfElements)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            string fizzBuzzSequence = fizzBuzz.Get(numberOfElements);

            Assert.Equal(expectedFizzBuzz, fizzBuzzSequence);
        }
    }
}
