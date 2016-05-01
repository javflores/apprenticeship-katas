using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Get(int numberOfElements)
        {
            var integerSequence = Enumerable.Range(1, numberOfElements);

            var fizzBuzzSequence = integerSequence.Select(ToFizzBuzz);

            return string.Join(" ", fizzBuzzSequence);
        }

        private string ToFizzBuzz(int number)
        {
            if (number == 3)
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}