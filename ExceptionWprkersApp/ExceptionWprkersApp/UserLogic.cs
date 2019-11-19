using System;
using System.Collections.Generic;
using System.Linq;

namespace ExceptionWprkersApp
{
    /// <summary> Service for implement user logic. </summary>
    public partial class UserLogic
    {
        /// <summary> Service for work with worker. </summary>
        private readonly IWorkersService _workersService;

        /// <summary> Min value of employment year. </summary>
        private const int MinYear = 2000;

        /// <summary> Max value of employment year. </summary>
        private const int MaxYear = 2019;

        /// <summary> Default constructor. </summary>
        public UserLogic()
        {
            _workersService = new WorkersService();
        }

        /// <summary> Add new worker to list. </summary>
        /// <param name="fullName"> Full name of worker. </param>
        /// <param name="position"> Position of worker. </param>
        /// <param name="employmentYear"> Year the worker came to work. </param>
        public void AddNewWorker(string fullName, string position, int employmentYear)
        {
            var earlyYear = employmentYear < MinYear;
            var lateYear = employmentYear > MaxYear;
            if (earlyYear || lateYear)
            {
                throw new YearEnteredException();
            }

            _workersService.AddNewWorker(fullName, position, employmentYear);
            Console.WriteLine("Done. Worker are added.");
        }

        /// <summary> Display information about worker whose experience exceeds the specified one. </summary>
        /// <param name="targetExperience"> Current experience of worker. </param>
        public void DisplayInformationAboutWorker(int targetExperience)
        {
            var workers = GetWorkersWithCurrentExperience(targetExperience);
            if (!workers.Any())
            {
                Console.WriteLine("No workers with this experience were found.");
            }
            else
            {
                Console.WriteLine("Workers with target experience:\n");
                foreach (var worker in workers)
                {
                    Console.WriteLine($"Full name:{worker.FullName}\n" +
                                      $"Position:{worker.Position}\n" +
                                      $"Emplyment year:{worker.EmploymentYear}\n");
                }
            }
        }

        /// <summary> Get workers with current experience. </summary>
        /// <param name="targetExperience"> Current experience of worker. </param>
        /// <returns> Workers wirh current experience. </returns>
        private List<Worker> GetWorkersWithCurrentExperience(int targetExperience)
        {
            var workers = _workersService.Workers;
            var workersWithCurrentExp = new List<Worker>();
            foreach (var worker in workers)
            {
                var actualExperience = DateTime.Now.Year - worker.EmploymentYear;
                if (actualExperience >= targetExperience)
                {
                    workersWithCurrentExp.Add(worker);
                }
            }

            return workersWithCurrentExp;
        }
    }
}