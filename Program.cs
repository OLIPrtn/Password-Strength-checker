using System;

namespace pwdChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // BASIC IF STATEMENT EXAMPLE //
            // PASSWORD STRENGTH CHECKER. 


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Password strength checker.");
            Blank();
            Console.WriteLine("Is your password strong enough?");
            Blank();
            {
                // get the user to input string text
                Console.Write("Please enter your password: ");
                // store the users text password into a string variable. 
                string userPWD = Console.ReadLine();

                // IF STATEMENT - IF the users password text is less than 8 characters
                // AND the password length is less than 15 characters
                if (userPWD.Length > 8 && userPWD.Length < 15)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    // inform the user that the password is too short. 
                    Console.Write("Password is too short. it should be atleast 8 or more characters, 15 is much more secure");
                }
                // else if no string data was entered by the user, display an error message stating nothing was entered.
                else if (userPWD.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("No password was entered");
                }
                //else if the password is greater than 15 characters, display a successfull message!
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine($"The password {userPWD} is a secure password!");
                }
                
            }
        }

        static void Blank()
        {
            // method to make a blankline quicker. 
            Console.WriteLine();
        }
    }
}
