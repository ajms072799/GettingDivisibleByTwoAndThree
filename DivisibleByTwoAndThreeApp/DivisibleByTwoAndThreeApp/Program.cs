using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleByTwoAndThreeApp
{
    class Program
    {
        static void GettingTheDivisibleOfTheNumber(int userInputNumber)
        {
            if (userInputNumber % 2 == 0 && userInputNumber % 3 == 0)
            {
                Console.WriteLine(userInputNumber + " is divisible by 2 and 3!");
            }
            else if (userInputNumber % 2 == 0)
            {
                Console.WriteLine(userInputNumber + " is divisible by 2 not by 3");
            }
            else if (userInputNumber % 3 == 0)
            {
                Console.WriteLine(userInputNumber + " is divisible by 3 not by 2");
            }
            else
            {
                Console.WriteLine(userInputNumber + " is not divisible by 2 or 3");
            }
        }
        static void Main(string[] args)
        {
            // Getting the divisible by 2 and 3 application

            // Header of the application
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("\tGetting the Divisible by 2 and 3");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("What's your name? "); // Getting the user name.
            string username = Console.ReadLine(); // after the input of the user name it will store in the username variable.
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Hello " + username + ", Welcome! to my Application."); // Displaying the name of the user
            Console.Write("Now enter a number that you want to know if is divisible by 2 or 3: "); // Getting the number of user 
            int userInputNumber = Int32.Parse(Console.ReadLine()); // Storing the number the user provided.

            // Displaying the result of inputed number.
            GettingTheDivisibleOfTheNumber(userInputNumber); // method of getting the divisible.
            
            // <~ End of the Getting The Divisible by 2 and 3 App
            Console.ReadLine();
        }
    }
}
