using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_on_ENUM
{
    enum WorkingDaysofTheWeek
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday
    }
    internal class Days_of_the_Week
    {
        public string Day(WorkingDaysofTheWeek day)
        {
            switch (day)
            {
                case WorkingDaysofTheWeek.monday:
                    return "\n  Monday is the first day of the week.\n  Today you have to prepare for presentation.";

                case WorkingDaysofTheWeek.tuesday:
                    return "\n  Tuesday is the second day of the week.\n  Today you have to prepare for meeting.";

                case WorkingDaysofTheWeek.wednesday:
                    return "\n  Wednesday is the third day of the week.\n  Today you have to prepare for report.";

                case WorkingDaysofTheWeek.thursday:
                    return "\n  Thursday is the fourth day of the week.\n  Today you have to prepare for review.";

                case WorkingDaysofTheWeek.friday:
                    return "\n  Friday is the fifth day of the week.\n  Today you have to prepare for weekend.";

                default:
                    return "\nInvalid day.";

            }
        }
    }
}
