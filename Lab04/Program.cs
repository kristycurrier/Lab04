using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            bool doAgain = true;

            do
            {
                int number = GetNumber();
                PrintValues(number);
                doAgain = ContinueTheProgram();
            } while (doAgain);
            Console.ReadKey();
        }

        public static int GetNumber()
        {
            bool realInteger = false;
            int number = 0;
            
            do
            {
                Console.Write("\nEnter a positive integer: ");
                realInteger = int.TryParse(Console.ReadLine(), out number);
                if (number < 0)
                {
                    realInteger = false;
                }
            } while (realInteger == false);
                return number;
        }

        public static void PrintValues(int number)
        {
            Console.WriteLine("Number\t\tSquared\t\tCubed");
            Console.WriteLine("=======\t\t=======\t\t=======");

            for (int i = 1; i <= number; i++)
            {
                int squared = i * i;
                int cubed = i * i * i;
                Console.WriteLine($"{i}\t\t{squared}\t\t{cubed}");
            }
        }

        public static bool ContinueTheProgram()
        {
            bool repeatTheProgram = true;
            bool validInput = false;

            do {
                Console.Write("Continue? (y/n) ");
                string yesNoAnswer = Console.ReadLine();
                if (yesNoAnswer.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    repeatTheProgram = true;
                    validInput = true;
                } else if (yesNoAnswer.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Goodbye!");
                    repeatTheProgram = false;
                    validInput = true;
                } else
                {
                    Console.WriteLine("That isn't a valid input, type y for yes or n for no.");
                        validInput = false;
                }
            } while (validInput == false);
            return repeatTheProgram;
        }
    }
}
