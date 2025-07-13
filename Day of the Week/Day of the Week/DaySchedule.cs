using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_the_Week
{
    enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    internal class DaySchedule
    {
        public Day Schedule(int day)
        {
            switch (day)
            {
                case 1:
                    return Day.Monday;

                case 2:
                    return Day.Tuesday;

                case 3:
                    return Day.Wednesday;

                case 4:
                    return Day.Thursday;

                case 5:
                    return Day.Friday;

                case 6:
                    return Day.Saturday;

                case 7:
                    return Day.Sunday;

                default:
                    return 0;
            }
        }
    }
}
