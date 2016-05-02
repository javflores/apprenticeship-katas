using System.Collections;
using System.Collections.Generic;

namespace FibonacciKata
{
    public class FibonacciSequence : IEnumerable<int>
    {
        private readonly int _numberOfElements;
        private readonly IList<int> _sequence;

        public FibonacciSequence(int numberOfElements)
        {
            _numberOfElements = numberOfElements;
            _sequence = new List<int>();
        }

        public IEnumerator<int> GetEnumerator()
        {
            if (_numberOfElements == 1)
            {
                _sequence.Add(1);
            }

            return _sequence.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}