using Xunit;

namespace LeapYear
{
    public class LeapYearTests
    {
        [Theory]
        [InlineData(2001)]
        [InlineData(1900)]
        public void Common_year(int commonYear)
        {
            Assert.False(LeapYear.IsLeap(commonYear));
        }

        [Fact]
        public void Typical_leap_year_is_divisible_by_4_and_not_divisible_by_100()
        {
            Assert.True(LeapYear.IsLeap(1996));
        }

        [Fact]
        public void Atypical_Leap_year_is_divisible_by_400()
        {
            Assert.True(LeapYear.IsLeap(2000));
        }
    }
}
