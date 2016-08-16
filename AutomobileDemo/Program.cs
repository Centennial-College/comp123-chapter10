using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FinancedAutomobile[] financedAutomobiles;

            financedAutomobiles = new FinancedAutomobile[]{
                new FinancedAutomobile(23, "good", 2000, 20423.21,10000,0.05),
                new FinancedAutomobile(123, "okay", 2005, 40423.21,10000,0.10),
                new FinancedAutomobile(223, "bad", 2001, 2423.21,1000,0.5022),
                new FinancedAutomobile(323, "godly", 2020, 200423.21,100000,2.3219)
            };

            foreach (var fa in financedAutomobiles)
            {
                Console.WriteLine(fa);
            }

            DisplayTotalOfAllFinancedAutomobiles(financedAutomobiles);

        }

        private static void DisplayTotalOfAllFinancedAutomobiles(Automobile[] automobiles)
        {
            double total = 0;
            foreach (Automobile automobile in automobiles)
            {
                total += automobile.Price;
            }
            Console.WriteLine("The total price of all the automobiles is {0:C}", total);
        }
    }
}
