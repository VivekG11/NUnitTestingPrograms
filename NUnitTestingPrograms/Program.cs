using System;

namespace NUnitTestingPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N Unit Testing Programs.......");
            /*.........................................
             * Create a switch method to choose a particular operation 
             * ............................................*/
            Console.WriteLine("Enter an Option :");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine("Calculating Minimum number of notes :");
                    VendingMachine.FindingMinimumNotes();
                    break;
                case 2:
                    Console.WriteLine("Finding day of a particular date");
                    WeekDay.FindingDay();
                    break;
                case 3:
                    Console.WriteLine("Coverting temperature :");
                    TemperatureConversion.Conversion();
                    break;
                case 4:
                    Console.WriteLine("Calculating Monthly Payments :");
                    Payment.MonthlyPayment();
                    break;
                case 5:
                    Console.WriteLine("Finding root of a number :");
                    NewtonSquareRoot.SquareRoot();
                    break;
                case 6:
                    Console.WriteLine("Converting to binary :");
                    Binary.ConvertToBinary();
                    break;
                default:
                    break;
            }
        }
    }
}
