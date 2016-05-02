using System.Collections.Generic;

namespace FibonacciKata
{
    public class FibonacciSequence
    {
        public IEnumerable<int> Generate(int numberOfElements)
        {
            if (numberOfElements == 0)
            {
                return new List<int>();
            }

            return Next(numberOfElements, 0, new List<int>());
        }

        private IList<int> Next(int numberOfElements, int currentElement, IList<int> currentSequence)
        {
            if (numberOfElements == currentElement)
            {
                return currentSequence;
            }

            var nextFibonacci = GetNextFibonacci(currentElement, currentSequence);
            currentSequence.Add(nextFibonacci);
            return Next(numberOfElements, currentElement + 1, currentSequence);
        }

        private int GetNextFibonacci(int currentElement, IList<int> currentSequence)
        {
            return currentElement < 2 ? 1 : currentSequence[currentElement - 1] + currentSequence[currentElement - 2];
        }
    }
}