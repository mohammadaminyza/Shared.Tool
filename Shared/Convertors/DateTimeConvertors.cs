using System;
using System.Globalization;

namespace Shared.Convertors
{
    public static partial class DateTimeConvertors
    {
        public static string ConvertDateTimeToPersianCalender(this DateTime dateTime)
        {
            var persianCalender = new PersianCalendar();
            var year = persianCalender.GetYear(dateTime);
            var month = persianCalender.GetMonth(dateTime);
            var day = persianCalender.GetDayOfMonth(dateTime);

            return $"{year}/{month}/{day}";
        }

        public static DateTime ConvertBackDateTimeToPersianCalender(this string dateTime)
        {
            var sliceDates = SlicePersianDate(dateTime);

            return new DateTime(sliceDates[0], sliceDates[1], sliceDates[2], new PersianCalendar());
        }

        private static int[] SlicePersianDate(string dateTime)
        {
            var year = int.Parse(dateTime.Split("/")[0]);
            var month = int.Parse(dateTime.Split("/")[1]);
            var day = int.Parse(dateTime.Split("/")[2]);

            return new int[]
                {year, month, day};
        }
    }
}
