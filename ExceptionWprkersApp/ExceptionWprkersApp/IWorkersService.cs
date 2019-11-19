using System;
using System.Collections.Generic;

namespace ExceptionWprkersApp
{
    /// <summary> Service for work with worker. </summary>
    public interface IWorkersService
    {
        /// <summary>
        /// Add new worker to list.
        /// </summary>
        /// <param name="fullName"> Full name of worker. </param>
        /// <param name="position"> Position of worker. </param>
        /// <param name="employmentYear"> Year the worker came to work. </param>
        void AddNewWorker(string fullName, string position, int employmentYear);

        /// <summary> List of workers. </summary>
        List<Worker> Workers { get; }
    }
}