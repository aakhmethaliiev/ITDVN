using System;

namespace ExceptionWprkersApp
{
    internal class Program
    {
        private static void Main()
        {
            var userLogic = new UserLogic();
            userLogic.AddNewWorker("Anton", "Software developer", 2019);
            userLogic.AddNewWorker("Mykhailo", "Software developer", 2017);
            userLogic.AddNewWorker("Artem", "QA", 2018);
            userLogic.AddNewWorker("Dmitro", "Lead Software developer", 2016);
            userLogic.AddNewWorker("Volodimir", "Line manager", 2017);

            Console.Write("\nEnter targer experience - ");
            var targetExperience = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            userLogic.DisplayInformationAboutWorker(targetExperience);
            Console.ReadKey();
        }
    }
}
