using System.Collections.Generic;

namespace FibonacciKata
{
    public class FibonacciSequence
    {
        private int _numberOfElements;
        private IList<int> _sequence;

        public IEnumerable<int> Generate(int numberOfElements)
        {
            _numberOfElements = numberOfElements;
            _sequence = new List<int>();

            if (_numberOfElements > 0)
            {
                BuildSequence(0);
            }

            return _sequence;
        }

        private void BuildSequence(int currentIndex)
        {
            if (IsSequenceGenerated(currentIndex))
            {
                return;
            }

            var nextFibonacci = NextFibonacci(currentIndex);
            _sequence.Add(nextFibonacci);

            BuildSequence(currentIndex + 1);
        }

        private bool IsSequenceGenerated(int currentIndex)
        {
            return currentIndex == _numberOfElements;
        }

        private int NextFibonacci(int currentIndex)
        {
            return currentIndex < 2 
                ? 1 
                : _sequence[currentIndex - 1] + _sequence[currentIndex - 2];
        }
    }
}