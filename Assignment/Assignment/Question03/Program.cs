using System;

namespace Question03
{
    internal class Program
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        public double Div(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            return (double)x / y;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            int choice;

            do
            {
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1: Add, 2: Sub, 3: Multiply, 4: Divide, 5: Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter value of X");
                        int x = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter value of Y");
                        int y = Convert.ToInt32(Console.ReadLine());
                        int result = p1.Add(x, y);  
                        Console.WriteLine($"Result: {result}");
                        break;

                    case 2:
                        Console.WriteLine("Enter value of X");
                        int x1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter value of Y");
                        int y1 = Convert.ToInt32(Console.ReadLine());
                        int result1 = p1.Sub(x1, y1);  
                        Console.WriteLine($"Result: {result1}");
                        break;

                    case 3:
                        Console.WriteLine("Enter value of X");
                        int x2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter value of Y");
                        int y2 = Convert.ToInt32(Console.ReadLine());
                        int result2 = p1.Mul(x2, y2);  
                        Console.WriteLine($"Result: {result2}");
                        break;

                    case 4:
                        Console.WriteLine("Enter value of X");
                        int x3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter value of Y");
                        int y3 = Convert.ToInt32(Console.ReadLine());
                        double result3 = p1.Div(x3, y3);  
                        if (!double.IsNaN(result3))  
                        {
                            Console.WriteLine($"Result: {result3}");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exiting From Calculator...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!!!!");
                        break;
                }

            } while (choice != 5);  
        }
    }
}
