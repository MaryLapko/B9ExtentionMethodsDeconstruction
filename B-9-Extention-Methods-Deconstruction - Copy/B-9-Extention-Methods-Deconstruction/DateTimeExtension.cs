using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExtensions
{
    public static class DateTimeExtension
    {
        public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hour, out int minute, out int second)
        {
            year = dateTime.Year;
            month = dateTime.Month;
            day = dateTime.Day;
            hour = dateTime.Hour;
            minute = dateTime.Minute;
            second = dateTime.Second;
        }
    }
}
