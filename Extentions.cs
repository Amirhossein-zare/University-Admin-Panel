using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Panel_Uni
{
    static class Extentions
    {
        public static void PrintDateTime(this DateTime date)
        {
            PersianCalendar calendar = new PersianCalendar();

            int year = calendar.GetYear(date);
            int mounth = calendar.GetMonth(date);
            int day = calendar.GetDayOfMonth(date);

            int hour = calendar.GetHour(date);
            int minute = calendar.GetMinute(date);
            int second = calendar.GetSecond(date);

            string dateN = year + "/" + mounth + "/" + day;
            string timeN = hour + ":" + minute + ":" + second;

            Console.Clear();
            Console.WriteLine(dateN + "  " + timeN);
            Console.WriteLine();

        }
    }
}
