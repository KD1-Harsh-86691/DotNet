using System;

namespace Question02
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
                Console.WriteLine(name.ToString() + " " + gender.ToString() + " " + age.ToString() + " " + std.ToString() + " " + div.ToString() + " " + marks.ToString());
            }

        }

        static void Main(string[] args)
        {
            Student[] studentsArray;

            CreateArray(out studentsArray);
            AcceptInfo(studentsArray);

            Console.WriteLine("\nOriginal Student Array:");
            PrintInfo(studentsArray);


            Student[] reversedArray = new Student[studentsArray.Length];
            ReverseArray(studentsArray, reversedArray);


            Console.WriteLine("\nReversed Student Array:");
            PrintInfo(reversedArray);

            Console.ReadLine();
        }

        public static void CreateArray(out Student[] array)
        {
            Console.Write("Enter the number of students: ");
            int size = int.Parse(Console.ReadLine());
            array = new Student[size];
        }

        public static void AcceptInfo(Student[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"\nEnter details for Student {i + 1}:");
                array[i] = new Student();
                array[i].AcceptDetails();
            }
        }

        public static void PrintInfo(Student[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                array[i].PrintDetails();
            }
        }

        public static void ReverseArray(Student[] original, Student[] reversed)
        {
            for (int i = 0; i < original.Length; i++)
            {
                reversed[i] = original[original.Length - i - 1];
            }
        }



    }
}
