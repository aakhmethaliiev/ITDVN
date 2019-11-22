namespace CollectionOfMonths
{
    /// <summary>
    /// Provide Month with name, index and numbers of days.
    /// </summary>
    public class Month
    {
        /// <summary> Constructor of parameters. </summary>
        /// <param name="monthName"> Name of month. </param>
        /// <param name="index"> Index of month. </param>
        /// <param name="daysNumber"> Number of days in month. </param>
        public Month(string monthName, int index, int daysNumber)
        {
            MonthName = monthName;
            Index = index;
            DaysNumber = daysNumber;
        }

        /// <summary> Name of month. </summary>
        public string MonthName { get; }

        /// <summary> Index of month. </summary>
        public int Index { get; }

        /// <summary> Number of days in month. </summary>
        public int DaysNumber { get; }
    }
}