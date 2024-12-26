using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your number2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition = "+ (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Substraction = " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Division = " + (num1 / num2));
                    break;
                case 4:
                    Console.WriteLine("Multiplication = " + (num1 * num2));
                    break;
                default:
                    Console.WriteLine("Wrong Choice...");
                    break;
            }

        }
    }
}
