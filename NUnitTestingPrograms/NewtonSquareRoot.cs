using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingPrograms
{
    class NewtonSquareRoot
    {
        public static void SquareRoot()
        {
            /*.............................................
             * create  a variable to store the input
             * ..............................................*/
            Console.WriteLine("Enter a value :");
            double num = Convert.ToDouble(Console.ReadLine());
            double x = num;
            double root;

            double l = 0.00001;
            while(true)
            {
                /*.............................................
                 * Calculating root 
                 * .................................*/
                root = 0.5 * (x + (num / x));
                if(Math.Abs(root - x)<l)
                {
                    break;
                }
                x = root;
            }

            Console.WriteLine("The root of number is : "+root);
        }
    }
}
