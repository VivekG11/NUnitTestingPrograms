using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingPrograms
{
    class Binary
    {
        public static void ConvertToBinary()
        {
            Console.WriteLine("Enter a number to convert to binary :");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] binary = new int[20];
            for(i = 0; num > 0; i++)
            {
                binary[i] = num % 2;
                num = num / 2;
            }
            Console.WriteLine("Binary number of given number is :");
            for(i = i - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
        }
    }
}
