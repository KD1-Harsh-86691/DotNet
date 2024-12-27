using System;

namespace Question01
{
    internal class Program
    {
        public struct Student
        {
            private string name;
            private int age;
            private int std;
            private char div;
            private bool gender;
            private double marks;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public int Std
            {
                get { return std; }
                set { std = value; }
            }

            public char Div
            {
                get { return div; }
                set { div = value; }
            }

            public bool Gender
            {
                get { return gender; }
                set { gender = value; }
            }

            public double Marks
            {
                get { return marks; }
                set { marks = value; }
            }

            // Parameterized constructor
            public Student(string name, bool gender, int age, int std, char div, double marks)
            {
                this.name = name;
                this.gender = gender;
                this.age = age;
                this.std = std;
                this.div = div;
                this.marks = marks;
            }

            public void AcceptDetails()
            {
                Console.Write("Enter Name: ");
                this.name = Console.ReadLine();

                Console.Write("Enter Gender (True -> Male, False -> Female): ");
                this.gender = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Enter Age: ");
                this.age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Division (A or B): ");
                this.div = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter Marks: ");
                this.marks = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Standard: ");
                this.std = Convert.ToInt32(Console.ReadLine());
            }

            public void PrintDetails()
            {
                Console.WriteLine("============================");
                Console.WriteLine("Student Details:");

                Console.WriteLine("Name = " + (name));
                Console.WriteLine("Marks = " + (marks));
                Console.WriteLine("Div = " + (div));
                Console.WriteLine("Age = " +(age));
                Console.WriteLine("Gender = " + (gender));
                Console.WriteLine("Standard = " +(std));
            }
        }

        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.AcceptDetails();

            s1.PrintDetails();
        }
    }
}
