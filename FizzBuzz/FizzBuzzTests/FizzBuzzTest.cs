using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void FizzBuzz_for_one_element_outputs_one_number()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            string fizzBuzzSequence = fizzBuzz.Get(1);

            Assert.Equal("1", fizzBuzzSequence);
        }

        [Fact]
        public void FizzBuzz_for_two_elements_outputs_two_numbers()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            string fizzBuzzSequence = fizzBuzz.Get(2);

            Assert.Equal("1 2", fizzBuzzSequence);
        }

        [Fact]
        public void FizzBuzz_for_three_elements_includes_fizz()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            string fizzBuzzSequence = fizzBuzz.Get(3);

            Assert.True(fizzBuzzSequence.Contains("Fizz"));
        }

        [Fact]
        public void FizzBuzz_for_six_elements_includes_two_fizz()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            string fizzBuzzSequence = fizzBuzz.Get(6);

            Assert.True(fizzBuzzSequence.EndsWith("Fizz"));
        }

    }
}
