using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanConverter
    {
        private readonly IDictionary<int, string> mappings = 
            new Dictionary<int, string>()
            {
                { 40, "XL"},
                { 10, "X"},
                { 9, "IX"},
                { 5, "V"},
                { 4, "IV"},
                { 1, "I"}
            };

        public string Convert(int number)
        {
            string result = string.Empty;
            var mappingsEnumerator = mappings.GetEnumerator();

            while (mappingsEnumerator.MoveNext())
            {
                var mapping = mappingsEnumerator.Current;

                while (number >= mapping.Key)
                {
                    result += mapping.Value;
                    number -= mapping.Key;
                }
            }

            return result;
        }
    }
}
