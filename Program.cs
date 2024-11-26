using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_mean_of_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the numbers in the format number,number"); 

            Console.Write("Number 1: ");
            double.TryParse(Console.ReadLine() , out double number1);

            Console.Write("Number 2: ");
            double.TryParse(Console.ReadLine(), out double number2);

            double result = (number1 + number2) / 2;
            Console.WriteLine("\nArithmetic mean: " + result);

            Console.Write("\nWrite your feedback: ");
            Console.ReadLine();
        }
    }
}
