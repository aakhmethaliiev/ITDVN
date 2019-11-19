using System;

namespace ExceptionWprkersApp
{
    public partial class UserLogic
    {
        public class YearEnteredException : Exception
        {
            public void ShowError()
            {
                Console.WriteLine("Wrong year format!");
            }
        }
    }
}