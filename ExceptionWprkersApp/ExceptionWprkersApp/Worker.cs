using System;

namespace ExceptionWprkersApp
{
    /// <summary> Model which contain information about worker. </summary>
    public class Worker
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="fullName"> Full name of worker. </param>
        /// <param name="position"> Position of worker. </param>
        /// <param name="employmentYear"> Year the worker came to work. </param>
        public Worker(string fullName, string position, int employmentYear)
        {
            FullName = fullName;
            Position = position;
            EmploymentYear = employmentYear;
        }

        /// <summary> Full name of worker. </summary>
        public string FullName { get; }

        /// <summary> Position of worker. </summary>
        public string Position { get; }

        /// <summary> Year the worker came to work. </summary>
        public int EmploymentYear { get; }
    }
}