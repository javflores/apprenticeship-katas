namespace LeapYear
{
    public class LeapYear
    {
        public static bool IsLeap(int year)
        {
            return IsTypicalLeapYear(year) || IsAtypicalLeapYear(year);
        }

        private static bool IsTypicalLeapYear(int year)
        {
            return year%4 == 0 && year%100 != 0;
        }

        private static bool IsAtypicalLeapYear(int year)
        {
            return year%400 == 0;
        }
    }
}