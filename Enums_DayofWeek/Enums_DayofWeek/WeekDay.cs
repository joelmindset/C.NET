using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_DayofWeek
{
    public class WeekDay
    {
        // instance variable
        public DayofWeek DayofWeek { get; set; }
    }

    // enum for week days
    public enum DayofWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
