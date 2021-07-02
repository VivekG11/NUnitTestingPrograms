using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingPrograms
{
    class Payment
    {
        public static void MonthlyPayment()
        {
            /*......................................................
             * Create three variables to calculate payment
             * ...............................................*/
            Console.WriteLine("Enter the Principle Amount : ");
            double principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Period :");
            double years = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate of Interest");
            double interest = Convert.ToDouble(Console.ReadLine());


            /*..............................................
             * create local variables to calculate months abd rate of interest
             * ..................................................*/

            double a = 12 * years;
            double b = interest / (12 * 100);
            double c = Math.Pow(1 + b, a);

            //Calculating payment 
            double payment = (principle * b * c) / (c - 1);

            Console.WriteLine("Monthly Payment is :"+ Math.Round(payment));


        }
    }
}
