namespace ExceptionWprkersApp
{
    /// <summary> Model which contain information about worker. </summary>
    public class Worker
    {
        /// <summary> Full name of worker. </summary>
        private readonly string _fullName;

        /// <summary> Position of worker. </summary>
        private readonly string _position;

        /// <summary> Year the worker came to work. </summary>
        private readonly int _employmentYear;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="fullName"> Full name of worker. </param>
        /// <param name="position"> _position </param>
        /// <param name="employmentYear"> _employmentYear </param>
        public Worker(string fullName, string position, int employmentYear)
        {
            _fullName = fullName;
            _position = position;
            _employmentYear = employmentYear;
        }

        public string FullName => _fullName;

        public string Position => _position;

        public int EmploymentYear => _employmentYear;
    }
}