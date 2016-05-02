using System.Collections;
using System.Collections.Generic;

namespace FibonacciKata
{
    public class FibonacciSequence
    {
        public IEnumerable<int> Generate(int numberOfElements)
        {
            var sequence = new List<int>();

            if (numberOfElements >= 1)
            {
                sequence.Add(1);
            }

            if (numberOfElements == 2)
            {
                sequence.Add(1);
            }

            return sequence;
        }
    }
}