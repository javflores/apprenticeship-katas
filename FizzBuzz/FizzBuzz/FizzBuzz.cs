using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Get(int numberOfElements)
        {
            var integerSequence = Enumerable.Range(1, numberOfElements);

            return integerSequence
                .Select(ToFizzBuzz)
                .Aggregate((element, nextElement) => $"{element} {nextElement}");
        }

        private string ToFizzBuzz(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}