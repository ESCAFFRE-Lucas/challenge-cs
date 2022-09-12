using System;

namespace CSharpDiscovery.Quest02
{
    public class TodayAtMidnight_Exercice
    {
        public static DateTime TodayAtMidnight()
        {
            var dateAndTime = DateTime.Now;
            return dateAndTime.Date;
        }
    }
}