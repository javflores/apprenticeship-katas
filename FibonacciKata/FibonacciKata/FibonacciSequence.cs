using System.Collections;
using System.Collections.Generic;

namespace FibonacciKata
{
    public class FibonacciSequence : IEnumerable<int>
    {
        private readonly int _numberOfElements;
        private List<int> _currentSequence;

        public FibonacciSequence(int numberOfElements)
        {
            _numberOfElements = numberOfElements;
        }

        public IEnumerator<int> GetEnumerator()
        {
            _currentSequence = new List<int>();

            if (_numberOfElements > 0)
            {
                BuildSequence(0);
            }

            return _currentSequence.GetEnumerator();
        }

        private void BuildSequence(int currentIndex)
        {
            if (IsSequenceGenerated(currentIndex))
            {
                return;
            }

            var nextFibonacci = NextFibonacci(currentIndex);
            _currentSequence.Add(nextFibonacci);

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
                : _currentSequence[currentIndex - 1] + _currentSequence[currentIndex - 2];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}