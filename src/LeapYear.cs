using System;
using System.Globalization;

namespace CSharp.Training
{
    public class LeapYear
    {
        public string LeapYearCalendar(int anio)
        {
            string result = String.Empty; ;
            GregorianCalendar calendar = new GregorianCalendar();

            if (calendar.IsLeapYear((anio)))
            {
                result = "LeapYear";
            }
            else
            {
                result = "NoLeapYear";
            }
            return result;
        }
    }
}
