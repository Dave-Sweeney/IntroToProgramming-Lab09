using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgramming_Lab09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EX 1 Task 1.2:  Write output to the Console window to prompt the user for deciding to create
            // a student class or an instructor class.
            Console.WriteLine("Do you want to create a:\n S - Student\n I - Instructor\n Q - Quit");
            
            // EX 1 Task 2:  Read the response from the user by using the Console.Read() method.
            // Store the value in a char variable.

            char input = (char)Console.Read();

            Console.WriteLine("You said: {0}", input);

            Console.ReadKey();
        }
    }
}
