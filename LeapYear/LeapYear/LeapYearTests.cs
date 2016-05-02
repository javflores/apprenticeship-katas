using Xunit;

namespace LeapYear
{
    public class LeapYearTests
    {
        [Theory]
        [InlineData(2001, false)]
        [InlineData(1900, false)]
        [InlineData(1996, true)]
        [InlineData(2000, true)]
        public void Common_year(int commonYear, bool isLeap)
        {
            Assert.Equal(isLeap, LeapYear.IsLeap(commonYear));
        }
    }
}
