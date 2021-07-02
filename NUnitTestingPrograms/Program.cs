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
                default:
                    break;
            }
        }
    }
}
