using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciKata
{
    public class FibonacciSequence : IEnumerable<int>
    {
        private readonly int _numberOfElements;

        public FibonacciSequence(int numberOfElements)
        {
            _numberOfElements = numberOfElements;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return Enumerable.Empty<int>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}