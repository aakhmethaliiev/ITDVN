using System;
using System.Collections.Generic;

namespace ExceptionWprkersApp
{
    /// <inheritdoc />
    public class WorkersService : IWorkersService
    {
        /// <summary> Default constructor. </summary>
        public WorkersService()
        {
            Workers = new List<Worker>();
        }

        /// <inheritdoc />
        public void AddNewWorker(string fullName, string position, int employmentYear)
        {
            Workers.Add(new Worker(fullName, position, employmentYear));
        }

        /// <inheritdoc />
        public List<Worker> Workers { get; }
    }
}