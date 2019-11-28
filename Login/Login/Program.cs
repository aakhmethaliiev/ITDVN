using System;
using System.Text.RegularExpressions;

namespace Login
{
    internal class Program
    {
        /// <summary> Pattern for create login. </summary>
        private const string LoginPattern = "^[a-zA-Z]+$";

        /// <summary> Pattern for create password. </summary>
        private const string PasswordPattern = "^[_0-9\\W]+$";

        private static void Main()
        {
            Console.WriteLine("Sign up\n");
            Console.Write("Enter login - ");
            var login = Console.ReadLine();
            Console.Write("Enter password - ");
            var password = Console.ReadLine();

            var loginRegex = new Regex(LoginPattern);
            var loginValid = loginRegex.IsMatch(login);

            var passwordRegex = new Regex(PasswordPattern);
            var passwordValid = passwordRegex.IsMatch(password);

            if (loginValid && passwordValid)
            {
                Console.WriteLine("User are created.");
            }
            else
            {
                Console.WriteLine("Invalid login or password.");
            }

            Console.ReadKey();
        }
    }
}