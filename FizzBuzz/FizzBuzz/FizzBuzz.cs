using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Get(int numberOfElements)
        {
            var integerSequence = Enumerable.Range(1, numberOfElements);

            return string.Join(" ", integerSequence);
        }
    }
}