using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //vars of the globe!
        static int quarter = 0;
        static int dime = 0;
        static int nickle = 0;
        static int penney = 0;
        static void ChangeMaker(double num)
        {
            Console.WriteLine("Amount: " + num);
            while (num > 0.25)
            {
                num -= 0.25;
                quarter += 1;
            }
            while (num > 0.10)
            {
                num -= 0.10;
                dime += 1;
            }
            while (num > 0.05)
            {
                num -= 0.05;
                nickle += 1;
            }
            while (num > 0.01)
            {
                num -= 0.01;
                penney += 1;
            }
            Console.WriteLine("Quarters: " + quarter);
            Console.WriteLine("Dimes: " + dime);
            Console.WriteLine("Nickles: " + nickle);
            Console.WriteLine("Pennies: " + penney);
        }
        static void Main(string[] args)
        {
            ChangeMaker(1.34);
            Console.ReadKey();
        }
    }
}
