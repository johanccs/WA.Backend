using System;

namespace WA.Common.Helpers
{
    public static class DateHelper
    {
        public static DateTime GetDate(this DateTime date, string val)
        {
            var results = val.Split("/");

            if(results.Length == 3)
            {
                return new DateTime(
                    Convert.ToInt32(results[2]), Convert.ToInt32(results[1]), Convert.ToInt32(results[0]));
            }

            return DateTime.Now;
        }
    }
}
