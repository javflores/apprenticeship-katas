using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void FizzBuzz_for_one_element()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            string fizzBuzzSequence = fizzBuzz.Get(1);

            Assert.Equal("1", fizzBuzzSequence);
        }

        [Fact]
        public void FizzBuzz_for_two_elements()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            string fizzBuzzSequence = fizzBuzz.Get(2);

            Assert.Equal("1 2", fizzBuzzSequence);
        }
    }
}
