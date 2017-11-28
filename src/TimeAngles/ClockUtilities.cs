using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAngles
{
    public class ClockUtilities
    {

        public static double GetShortHandAngle(DateTime time)
        {
            // Formula: hour * (360/12) + ((360/12)/60 * min)

            return (time.Hour * 30) + (0.5 * time.Minute);
        }


        public static double GetLongHandAngle(DateTime time)
        {
            // Formula: (360/60) * min

            return 6 * time.Minute;
        }


        public static double GetHandAngle(DateTime time)
        {
            // Formula: if (long - short) <  180 =>  long - short
            //          else                     =>  (360 - long - short)

            var angle = GetLongHandAngle(time) - GetShortHandAngle(time);

            return  Math.Round(angle > 180 ? 360 - angle : angle, 2);
        }
    }
}
