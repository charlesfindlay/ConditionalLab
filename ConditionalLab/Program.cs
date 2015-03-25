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


            /*
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
            */


            // FizzBuzz


            /*
            string number = string.Empty;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                    number = i.ToString();
                else
                {
                    number = (i % 3 == 0) ? "Fizz" : string.Empty;
                    number += (i % 5 == 0) ? "Buzz" : string.Empty;
                }

                Console.WriteLine(number);
            }

            Console.ReadLine();
            */
            
              
             // Reverse

            /*
            Console.WriteLine("Type a string");
            string myString = Console.ReadLine();

            for (int i = myString.Length - 1; i >= 0; i--)
                Console.Write(myString[i]);

            Console.ReadLine();
            */


            // Multiples of 3 & 5 under 1000

            int sum = 0;

            for (int i = 1; i < 1000; i++)
                sum = (i % 3 == 0 || i % 5 == 0) ? sum + i : sum;

            Console.WriteLine("The sum of multiples of 3 or 5 below 1000 is {0}", sum);
            




            Console.ReadLine();

        }
    }
}
