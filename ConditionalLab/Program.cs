using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Progressive income tax calculator
            
            
            /*
            Console.Write("Enter your income: ");
            string userIncome = Console.ReadLine();
            int income = int.Parse(userIncome);

            int[] tax = new int[] { 1000, 4000, 9000 };
            int[] bracketTop = new int[] { 20000, 50000, 75000 };
            decimal[] rates = new decimal[] {.05M, .1M, .2M, .35M };

            decimal taxOwed = 0;

            if (income <= 20000)
                taxOwed = income * rates[0];
            else if (income > 20000 && income <= 50000)
                taxOwed = tax[0] + (income - bracketTop[0]) * rates[1];
            else if (income > 50000 && income <= 75000)
                taxOwed = tax[1] + (income - bracketTop[1]) * rates[2];
            else if (income > 75000)
                taxOwed = tax[2] + (income - bracketTop[2]) * rates[3];

            if (taxOwed == 0)
                Console.WriteLine("You don't owe any tax! Yippee. You're also probalby broke. Boo");
            else
                Console.WriteLine("You owe {0:C} in taxes this year.", taxOwed);

            Console.ReadLine();
            */


            // Time and classifications

            DateTime moment = new System.DateTime();
            moment = DateTime.Now;
            int seconds = moment.Second;

            Console.Write("Here is the time: ");
            Console.WriteLine(moment.ToLongTimeString());

            switch (seconds)
            {
                case (0):
                    Console.WriteLine("The new minute is just beginning");
                    break;
                case (15):
                    Console.WriteLine("We're one quarter done");
                    break;
                case (30):
                    Console.WriteLine("Half way there");
                    break;
                case (45):
                    Console.WriteLine("Getting close to down");
                    break;
                default:
                    Console.WriteLine("Working on it");
                    break;
            }

            Console.ReadLine();






        }
    }
}
