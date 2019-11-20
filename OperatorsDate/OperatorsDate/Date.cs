using System;

namespace OperatorsDate
{
    /// <summary>
    /// Class which provide Date with implemented subtract and inkrement.
    /// </summary>
    public class Date
    {
        /// <summary> Date. </summary>
        private readonly DateTime _date;

        /// <summary> Default Constructor. </summary>
        public Date()
        {
            _date = DateTime.Now;
        }

        /// <summary> Constructor with parameters. </summary>
        public Date(int year, int month, int day)
        {
            _date = CorrectDate(year, month, day);
        }

        /// <summary> 
        /// Checks the correctness of the entered date and return correct date. 
        /// </summary>
        /// <returns> Correct date. </returns>
        private static DateTime CorrectDate(int year, int month, int day)
        {
            while (DateIsIncorrect(year, month, day))
            {
                if (month > 12)
                {
                    var yearsInMounths = month / 12;
                    month = month % 12;
                    year += yearsInMounths;
                }
                else
                {
                    day = day - CorrectNumberOfDays(year, month, 31);
                    month++;
                }
            }

            return new DateTime(year, month, day);
        }

        /// <summary> Checks the correctness of the entered date. </summary>
        /// <returns> Return True if date is incorrect. </returns>
        private static bool DateIsIncorrect(int year, int month, int day)
        {
            try
            {
                new DateTime(year, month, day); 
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        /// <summary> Check number of days in targer month. </summary>
        /// <returns> Number of days in target month. </returns>
        private static int CorrectNumberOfDays(int year, int month, int day)
        {
            while (true)
            {
                try
                {
                    new DateTime(year, month, day - 1);
                    return day - 1;     
                }
                catch (Exception)
                {
                    day -= 1;
                }
            }
        }

        /// <summary> Operator "-" for 2 dates. </summary>
        /// <returns> Number of days between dates. </returns>
        public static int operator -(Date date1, Date date2)
        {
            var result = Math.Abs((date2._date - date1._date).Days);
            return result;
        }

        /// <summary> Increase the date by the number of days. </summary>
        /// <param name="date"> Current date. </param>
        /// <param name="days"> Number of days on which we will increase the date. </param>
        public static Date operator +(Date date, int days)
        {
            var tempDate = date._date;
            return new Date(tempDate.Year, tempDate.Month, tempDate.Day + days);
        }

        public override string ToString()
        {
            return string.Format($"{_date.Day}.{_date.Month}.{_date.Year}");
        }
    }
}