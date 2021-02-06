using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {

        public int GetDaysDiff(string startDate, string endDate)
        {
            DateTime start = Convert.ToDateTime(startDate);
            DateTime end = Convert.ToDateTime(endDate);

            int result = Math.Abs((end - start).Days);

            return result;
        }
    }
}
