using Xunit;

namespace LeapYear
{
    public class LeapYearTests
    {
        [Fact]
        public void Finds_common_year()
        {
            bool isLeap = new LeapYear(2001);
            Assert.False(isLeap);
        }
    }
}
