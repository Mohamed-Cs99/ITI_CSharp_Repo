using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {

        public static void Problem1()
        {
            Console.WriteLine("1.For one student 2.For many students ");
            Console.Write("Your Choice : ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Student student = new Student();
                    Console.Write("Name : ");
                    student.Name = Console.ReadLine();

                    bool SSN_Validation = false;

                    while (!SSN_Validation)
                    {
                        try
                        {
                            Console.Write("SSN : ");
                            student.SSN = Console.ReadLine();
                            SSN_Validation = true;
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                    }

                    Console.Write("Age : ");
                    student.Age = int.Parse(Console.ReadLine());

                    Console.Write("Address : ");
                    student.Address = Console.ReadLine();

                    Console.WriteLine("=========================");
                    Console.WriteLine(student.Print());

                    break;
                case 2:
                    Console.Write("How many students ? ");
                    int sNumber = int.Parse(Console.ReadLine());
                    Student[] StudentsList = new Student[sNumber];

                    Console.WriteLine("Students Data : ");

                    for (int i = 0; i < sNumber; i++)
                    {
                        StudentsList[i] = new Student();

                        Console.Write($"Student {i + 1} Name : ");
                        StudentsList[i].Name = Console.ReadLine();

                        bool SSN_Val = false;
                        while (!SSN_Val)
                        {
                            try
                            {
                                Console.Write($"Student {i + 1} SSN : ");
                                StudentsList[i].SSN = Console.ReadLine();
                                SSN_Val = true;
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                        }

                        Console.Write($"Student {i + 1} Age : ");
                        StudentsList[i].Age = int.Parse(Console.ReadLine());

                        Console.Write($"Student {i + 1} Address : ");
                        StudentsList[i].Address = Console.ReadLine();

                        Console.WriteLine("=========================");

                        Console.WriteLine("Students Data : ");



                    }
                    for (int j = 0; j < sNumber; j++)
                    {
                        Console.WriteLine($"Studend {j + 1} Info : ");
                        Console.WriteLine(StudentsList[j].Print());
                    }

                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }

        }


        public static void Problem2()
        {
            Console.WriteLine("Addition: " + Math.Add(10, 5)); // Output: 15
            Console.WriteLine("Subtraction: " + Math.Sub(10, 5)); // Output: 5
            Console.WriteLine("Multiplication: " + Math.Mul(10, 5)); // Output: 50
            Console.WriteLine("Division: " + Math.Div(10, 5)); // Output: 2
            Console.WriteLine("Remainder: " + Math.Reminder(10, 5)); // Output: 0
            Console.WriteLine("Division with Remainder: " + Math.Div(10, 3)); // Output: 3.333333
            Console.WriteLine("Remainder with Division: " + Math.Reminder(10, 3)); // Output: 1

        }

        public static void Problem3()
        {
            int[] arr = new int[10];

            Console.WriteLine("Array Data : ");
            for (int i = 0; i < 10; i++)
            {
                int tmp = int.Parse(Console.ReadLine());
                arr[i] = tmp;
            }

            void displayArr(int[] disArr)
            {
                Console.WriteLine("Array Elements : ");
                for (int i = 0; i < disArr.Length; i++)
                {
                    Console.Write($"{disArr[i]} ");
                }
                Console.WriteLine();
            }
            displayArr(arr);
            void Swap(int[] a, int i1, int i2)
            {
                int temp = a[i1];
                a[i1] = a[i2];
                a[i2] = temp;
            }

            Swap(arr, 1, 2);
            displayArr(arr);
        }
        static void Main(string[] args)
        {


            //Problem1();
            //Problem2(); 
            //Problem3(); 

            Program.Problem1(); 

        }
    }
}
