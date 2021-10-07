using System;

namespace Exponents_And_Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Requirements:
            //1. Prompts user for input of integer.
            //2. a. Program squares and cudes every number from 1 to user input number.
            //b. Display output as a table.
            //3. Prompts the user to continue (y/n).
            // Max number to store in int
                // int x;
                // x = 1290 * 1290 * 1290;
                // Console.WriteLine(x);
            
            //Intro
            Console.WriteLine("Welcome to the Square/Cube Game!");
            string name = askUser("\nWhat is your name?");
            Console.WriteLine($"\nHello, {name}!");

            bool userContinue = true;
            while (userContinue == true)
            {
                try
                {
                    string num = askUser("\nPlease pick a postive integer between 1 and 1290");
                    int numInt = int.Parse(num);

                    if (numInt > 0 && numInt <= 1290)
                    {
                        Console.WriteLine("\nNumber\t\tSquared\t\tCubed");
                        Console.WriteLine("=======\t\t=======\t\t=======");
                        for (int i = 0; i < numInt; i++)
                        {
                            Console.WriteLine($"{i+1}\t\t{Square(i+1)}\t\t{Cube(i+1)}");
                        }
                    }

                    bool inRange = RangeCheck(numInt);
                    userContinue = keepGoing();
                }
                catch
                {
                    Console.WriteLine("Please use number format only!");
                    userContinue = true;
                }

            }
        }
        //Methods:
        //Prompt user
        public static string askUser(string ask)
        {
            Console.WriteLine(ask);
            string output = Console.ReadLine();
            return output;
        }
        //Asking user to continue or not
        public static bool keepGoing()
        {
            string userStayGo = askUser("\nWould you like to continue? (y/n)");

            if (userStayGo == "y" || userStayGo == "yes")
            {
                return true;
            }
            else if(userStayGo == "n" || userStayGo == "no" )
            {
                Console.WriteLine($"\nThanks for playing. Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("\nI don't understand. Please try again!");
                return keepGoing();
            }
        }
        // Get's square of user number not using Math.Pow()
        public static int Square(int userNum)
        {
            int square = userNum * userNum;
            return square;
        }
        // Get's cube of user number not using Math.Pow()
        public static int Cube(int userNum)
        {
            int cube = userNum * userNum * userNum;
            return cube;
        }
        //Checking range of user number
        public static bool RangeCheck(int userNum)
        {
            if (userNum > 0 && userNum <= 1290)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"\n{userNum} is NOT between 1 and 1290");
                return false;
            }
        }

    }
}
