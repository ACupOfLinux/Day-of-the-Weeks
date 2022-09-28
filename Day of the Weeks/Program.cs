//////// THIS PROG IS MADE WITH ELSE IF STATMENTS AND NOT SWITCHES FOR EASY CHANGES ///////

using System.ComponentModel.Design;

namespace Daysoftheweeks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is today!");
            String dayoftheweek = Console.ReadLine();

            if (dayoftheweek == "monday")
            {
                Console.WriteLine("Its monday!");
            }

            else if (dayoftheweek == "tuesday")
            {
                Console.WriteLine("its chewsday innit!");
            }

            else if (dayoftheweek == "wednesday")
            {
                Console.WriteLine("Its wednesday!");
            }

            else if (dayoftheweek == "thursday")
            {
                Console.WriteLine("Its churdays innit mate!");
            }

            else if (dayoftheweek == "friday")
            {
                Console.WriteLine("FRIDAY FRIDAY GOTTA GET DOWN ON FRIDAY!!!!!!!!");
            }

            else if (dayoftheweek == "saturday")
            {
                Console.WriteLine("Happy Saturday!");
            }   

            else if (dayoftheweek == "sunday")
            {
                Console.WriteLine("Happy Sunday!");
            }

            else
            {
                Console.WriteLine("Make sure that you spell the days in lower case letters and you spell them RIGHT!");
            }


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Beep();
        }
    }
}

