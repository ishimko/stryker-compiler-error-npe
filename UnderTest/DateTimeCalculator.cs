using System;

namespace UnderTest
{
    public class DateTimeCalculator
    {
        public TimeSpan Diff(DateTime a, DateTime b) => a - b;

        public bool IsDefault(DateTime dateTime)
        {
            if (dateTime == default)
                return true;
            else
                return false;
        }
    }
}