using System.Globalization;

namespace Pilak.Utilities
{
    public static class DateHelper
    {
        public static string ToPersianDate(this DateTime dateTime)
        {
            var pc = new PersianCalendar();
            try
            {
                return
                    $"{pc.GetYear(dateTime).ToString().PadLeft(4, '0')}/{pc.GetMonth(dateTime).ToString().PadLeft(2, '0')}/{pc.GetDayOfMonth(dateTime).ToString().PadLeft(2, '0')}";
            }
            catch
            {
                return "";
            }
        }
        public static string ToPersianDate(this DateTime dateTime, string format)
        {
            var pc = new PersianCalendar();
            try
            {
                var date = format.Replace("Y", pc.GetYear(dateTime).ToString().PadLeft(4, '0'))
                        .Replace("mm", pc.GetMonth(dateTime).ToString())
                        .Replace("MM", pc.GetMonth(dateTime).ToString().PadLeft(2, '0'))
                        .Replace("dd", pc.GetDayOfMonth(dateTime).ToString())
                        .Replace("DD", pc.GetDayOfMonth(dateTime).ToString().PadLeft(2, '0'))
                        .Replace("ds", GetDayOfWeekString((int)pc.GetDayOfWeek(dateTime)).ToString())
                        .Replace("ms", GetMonthString(pc.GetMonth(dateTime)).ToString())
                    ;
                return date;
            }
            catch
            {
                return "";
            }
        }

        public static DateTime ToGregorianDate(string persianDateTime)
        {
            var pc = new PersianCalendar();
            try
            {
                var year = int.Parse(persianDateTime[..4]);
                var month = int.Parse(persianDateTime.Substring(5, 2));
                var day = int.Parse(persianDateTime.Substring(8, 2));
                var hour = int.Parse(persianDateTime.Substring(11, 2));
                var minute = int.Parse(persianDateTime.Substring(14, 2));
                var second = int.Parse(persianDateTime.Substring(17, 2));

                return pc.ToDateTime(year, month, day, hour, minute, second, 0);
            }
            catch
            {
                throw new ArgumentException("Invalid date and time format.", nameof(persianDateTime));
            }
        }

        private static string GetDayOfWeekString(int day)
        {
            var days = new[] { "یکشنبه", "دوشنبه", "سه شنبه", "چهارشنبه", "پنجشنبه", "جمعه", "شنبه" };
            return day <= days.Length ? days[day] : "";
        }

        private static string GetMonthString(int month)
        {
            var months = new[] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
            return month <= months.Length ? months[month - 1] : "";
        }

        public static string GetTimeAgo(this DateTime dateTime)
        {
            var now = DateTime.Now;
            var year = now.Year - dateTime.Year;
            var month = now.Month - dateTime.Month;
            var days = now.Day - dateTime.Day;
            var hours = now.Hour - dateTime.Hour;
            var minutes = now.Minute - dateTime.Minute;
            var seconds = now.Second - dateTime.Second;

            if (year > 0)
            {
                return $"{year} سال پیش";
            }
            else if (month > 0)
            {
                return $"{month} ماه پیش";
            }
            else if (days > 0)
            {
                return $"{days} روز پیش";
            }
            else if (hours > 0)
            {
                return $"{hours} ساعت پیش";
            }
            else if (minutes > 0)
            {
                return $"{minutes} دقیقه پیش";
            }
            else if (seconds > 0)
            {
                return $"{seconds} ثانیه پیش";
            }
            else
            {
                return "لحضاتی پیش";
            }
        }
    }
}
