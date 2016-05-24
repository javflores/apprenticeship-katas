using RomanNumerals;
using Xunit;

namespace RomanNumeralsTests
{
    public class RomanConverterShould
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(7, "VII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(40, "XL")]
        [InlineData(44, "XLIV")]
        [InlineData(50, "L")]
        [InlineData(90, "XC")]
        [InlineData(100, "C")]
        [InlineData(400, "CD")]
        [InlineData(500, "D")]
        [InlineData(900, "CM")]
        [InlineData(1000, "M")]
        [InlineData(846, "DCCCXLVI")]
        [InlineData(1999, "MCMXCIX")]
        [InlineData(2008, "MMVIII")]

        public void convert_number_to_roman(int number, string expected)
        {
            string romanNumeral = new RomanConverter().Convert(number);

            Assert.Equal(expected, romanNumeral);
        }
    }
}
