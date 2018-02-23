using System;
using System.Collections.Generic;
using System.Text;

namespace TimeUtilities
{
    public static class DateTimeFactory
    {
        public static DateTime FromUnixTimeStamp(double timestamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(timestamp);
            return dtDateTime;
        }
    }
}
