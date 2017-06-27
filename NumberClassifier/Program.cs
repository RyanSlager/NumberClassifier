using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberClassifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y";

            while (cont == "y")
            {
                // user is prompted for their name and an initial integer

                Console.WriteLine("Hello and welcome to our number classifier! What is your name? ");
                string uName = Console.ReadLine();
                Console.WriteLine($"{uName}, please enter an integer between 1 and 100");
                string uNum = Console.ReadLine();
                int uInt;
                 
                // confirming that the input can be parsed to an int, and is within the range specified
                // if it cannot be parsed or is out of range, the user will be prompted to reinput until they behave

                while (!Int32.TryParse(uNum, out uInt) || uInt < 1 || uInt > 100)
                {
                    Console.WriteLine($"{uName}, please enter an integer between 1 and 100");
                    uNum = Console.ReadLine();
                }

                // first if condition checks for odd numbers using % 2

                if (!(uInt % 2 == 0))
                {
                    // this if/else checks what range the number is in

                    if (uInt >= 60)
                    {
                        Console.WriteLine($"{uName}, {uInt} is odd.");
                    }

                    else
                    {
                        Console.WriteLine($"{uName}, {uInt} is odd.");
                    }

                }
                
                // the else if handles all even numbers

                else if ((uInt % 2 == 0))
                {
                    // again, the inner if/else tree handles ranges

                    if ((uInt <= 25))
                    {
                        Console.WriteLine($"{uName}, your number is even and less than 25");
                    }
                    else if ((uInt >= 26) && (uInt <= 60))
                    {
                        Console.WriteLine($"{uName}, your number is even");
                    }
                    else
                    {
                        Console.WriteLine($"{uName}, {uInt} is even");
                    }
                }

                //user is prompted to continue or quit

                Console.WriteLine("Continue? (y/n)");
                cont = Console.ReadLine();

                // user input for cont is checked

                while (cont != "y" && cont != "n")
                {
                    Console.WriteLine("Please enter y to continue or n to quit.");
                    cont = Console.ReadLine();
                }
            }
        }
    }
}
