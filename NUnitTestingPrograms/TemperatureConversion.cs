using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingPrograms
{
    class TemperatureConversion
    {
        public static void Conversion()
        {
            Console.WriteLine("Converting Temperature between Celsius and Fahrenheit");
            Console.WriteLine("Select an Option :");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter temperature in Celsius :");
                    double degree = Convert.ToDouble(Console.ReadLine());
                    ToFahrenheit(degree);
                    break;
                case 2:
                    Console.WriteLine("Enter temperature in Fahrenheit :");
                    double tem = Convert.ToDouble(Console.ReadLine());
                    ToCelsius(tem);
                    break;
                default:
                    Console.WriteLine("Enter a valid Option :");
                    break;

            }
        }

        /*............................
         * converting celsius to fahrenheit 
         * ...................................*/
        private static void ToFahrenheit(double degree)
        {
            double fahrenheit = degree * 9 / 5 + 32;
            Console.WriteLine($"{degree}C = {fahrenheit}F");
        }
        /*............................................
         * Converting fahrenheit to celsius
         * ...................................*/
        private static void ToCelsius(double tem)
        {
            double celsius = (tem - 32) * 5 / 9;
            Console.WriteLine($"{tem}F = {celsius}C");
        }
    }
}
