namespace LeapYear
{
    public class LeapYear
    {
        private readonly int _year;

        public LeapYear(int year)
        {
            _year = year;
        }

        public static implicit operator bool(LeapYear leapYear)
        {
            return false;
        }
    }
}