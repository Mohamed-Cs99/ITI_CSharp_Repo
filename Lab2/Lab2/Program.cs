using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            //#region Problem1 

            ////Write a program to use checked and unchecked Handle Exception of overflow You have a byte sum variable read values from user and sum them until overflow happens
            //byte sum = 0;
            //try
            //{

            //    do
            //    {
            //        Console.Write("Enter value please :");
            //        byte value = byte.Parse(Console.ReadLine());
            //        sum = checked((byte)(sum + value));
            //    } while (true);

            //}
            //catch (OverflowException of)
            //{
            //    Console.WriteLine("Overflow occured: " + of.Message);
            //}
            //catch (FormatException fx)
            //{
            //    Console.WriteLine("Invalid input: " + fx.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //#endregion


            //#region Problem2 

            ///*
            // array of 10 integers
            //    read all data inside array from user in runtime
            //    Read array values from the user
            //    Use print array as a function
            //    ● 1- array
            //    ○ min value and max value -don't use any ready function-
            //    ● 2- array
            //    ○ sort in same array -don't use any ready function-
            //    ● 3- array
            //    ○ search on number and return index
            // */

            //int[] arr = new int[10];

            //Console.WriteLine("Enter Array Values : ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Value {i + 1} : ");
            //    int value = int.Parse(Console.ReadLine());
            //    arr[i] = value;
            //}

            //Console.WriteLine("=======================");
            //PrintArr(arr);
            //Console.WriteLine("=======================");
            //// Minimum and Maximum function . 
            //void PrintArr(int[] a)
            //{
            //    int min = 100000000;
            //    int max = -100000000;

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] > max)
            //        {
            //            max = a[i];
            //        }

            //    }
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] < min)
            //        {
            //            min = a[i];
            //        }

            //    }

            //    Console.WriteLine($"Maximun number is : {max}");
            //    Console.WriteLine($"Minimum number is : {min}");
            //}


            //Console.WriteLine("=======================");

            //int SearchResult = SearchForNumber(arr);
            //if (SearchResult == -1)
            //{
            //    Console.WriteLine("Number not found!");
            //}
            //else
            //{
            //    Console.WriteLine($"Number found at index {SearchResult}");
            //}
            //Console.WriteLine("=======================");
            //// Search Function .
            //int SearchForNumber(int[] a)
            //{

            //    Console.Write("Search for number : ");
            //    int number = int.Parse(Console.ReadLine());
            //    int found = -1;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (number == a[i])
            //        {
            //            return i;
            //        }

            //    }
            //    return found;
            //}

            //// Sort array .
            //Console.WriteLine("=====================");
            //DisplayArray(arr); 
            //BubbleSort(arr);
            //DisplayArray(arr); 

            //Console.WriteLine("=====================");
            //void BubbleSort(int []a )
            //{

            //    int n = a.Length; 

            //    for(int i = 0; i<n-1; i++)
            //    {
            //        for(int j = 0; j<n-i-1; j++)
            //        {
            //            if(a[j] >a[j+1])
            //            {
            //                int temp = a[j];
            //                a[j] = a[j + 1];
            //                a[j + 1] = temp; 
            //            }
            //        }
            //    }


            //}
            //void DisplayArray(int[]a)
            //{
            //    for(int i =0; i<a.Length; i++)
            //    {
            //        Console.Write(a[i] + " "); 
            //    }
            //    Console.WriteLine(); 
            //}
            //#endregion


            #region Problem 3 
            //Calculate the subjects average grade in the studentsSubjectsGrades array; 

            Console.Write("Enter number of students : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number of subjects : ");
            int s = int.Parse(Console.ReadLine());

            int[][] StudentSubjects = new int[n][]; 

            for(int i = 0; i<n; i++)
            {
                StudentSubjects[i] = new int[s]; 
            }

            for(int i =0; i<n; i++)
            {
                for(int j = 0; j<s;j++)
                {
                    Console.Write($"Enter grade for student {i + 1}, subject {j + 1}: ");
                    StudentSubjects[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for(int i = 0; i< n;i++)
            {
                Console.Write($"Student {i + 1}: ");
                for (int j = 0; j<s; j++)
                {
                    Console.Write(StudentSubjects[i][j] + (j < s - 1 ? ", " : ""));

                }
                Console.WriteLine(); 
            }



            #endregion




        }
    }
}
