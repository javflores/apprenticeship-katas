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

            return GenerateSequence(numberOfElements, 0, new List<int>());
        }

        private IList<int> GenerateSequence(int numberOfElements, int currentIndex, IList<int> currentSequence)
        {
            if (AllElementsGenerated(numberOfElements, currentIndex))
            {
                return currentSequence;
            }

            var nextFibonacci = NextFibonacci(currentIndex, currentSequence);
            currentSequence.Add(nextFibonacci);

            return GenerateSequence(numberOfElements, currentIndex + 1, currentSequence);
        }

        private bool AllElementsGenerated(int numberOfElements, int currentIndex)
        {
            return numberOfElements == currentIndex;
        }

        private int NextFibonacci(int currentElement, IList<int> currentSequence)
        {
            return currentElement < 2 
                ? 1 
                : currentSequence[currentElement - 1] + currentSequence[currentElement - 2];
        }
    }
}