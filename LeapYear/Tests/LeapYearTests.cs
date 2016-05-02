using Xunit;
using static LeapYear.LeapYear;

namespace Tests
{
    public class LeapYearShould
    {
        [Theory]
        [InlineData(2001, false)]
        [InlineData(1900, false)]
        [InlineData(1996, true)]
        [InlineData(2000, true)]
        public void find_if_year_is_leap(int commonYear, bool isLeap)
        {
            Assert.Equal(isLeap, IsLeap(commonYear));
        }
    }
}
