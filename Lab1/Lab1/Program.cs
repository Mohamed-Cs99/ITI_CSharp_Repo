using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Problem 1 
            //Write a C# Sharp program to print the sum of two numbers. //string interpolation

            Console.Write("Number 1 : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Number 2 : ");
            int number2 = int.Parse(Console.ReadLine());
            int result = number1 + number2;

            Console.WriteLine($"Restult : {result}");

            #endregion

            #region problem 2 
            /*
             Write a C# Sharp program to print the result of the specified operations. Test data:
                ○ -1 + 4 * 6
                ○ ( 35+ 5 ) % 7
                ○ 14 + -4 * 6 / 11
                ○ 2 + 15 / 6 * 1 - 7 % 2     
             */

            int result1 = -1 + 4 * 6;
            Console.WriteLine($"Result 1 : {result1}");

            int result2 = (35 + 5) % 7;
            Console.WriteLine($"Result 2 : {result2}");

            int result3 = 14 + -4 * 6 / 11;
            Console.WriteLine($"Result 3 : {result3}");

            int result4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"Result 4 : {result4}");


            #endregion

            #region problem 3 

            // Int z = (x++) + x; 

            Console.Write("X : ");
            int x = int.Parse(Console.ReadLine());

            int z = (x++) + x;
            Console.WriteLine($"Z = {z}");

            #endregion

            #region problem 4 
            // Write a C# program to print the comparing results between three integer values. [At least 5 complex expressions]

            Console.Write("number 1 : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("number 2 : ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("number 3 : ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(a == b && b == c);

            Console.WriteLine((a > b && a > c) || (b > a && b > c) || (c > a && c > b));// always true 

            Console.WriteLine(b > a && b < c);

            Console.WriteLine(a * b <= c);

            Console.WriteLine(a >= ((a + b + c) / 3));


            #endregion

            #region problem 5 

            Console.Write("Plz enter year : ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Plz enter month : ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Plz enter day : ");
            int day = int.Parse(Console.ReadLine());
            if (ValidateDate(year, month, day))
            {
                Console.WriteLine("Enter date is valid!"); 
            }
            else
            {
                Console.WriteLine("Enter date is invalid!"); 
            }
            

            bool ValidateDate(int y , int m , int d )
            {
                if(y < 2000 || y >  2024)
                {
                    return false; 
                }

                if(m < 1 || m > 12 )
                {
                    return false; 
                }

                int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if(isLeapYear(y))
                {
                    daysInMonth[1] = 29; 
                }

                if (d < 1 || d > daysInMonth[m - 1])
                {
                    return false; 
                }

                return true; 
            }

            bool isLeapYear(int ly)
            {
                return (ly % 4 == 0 && ly % 100 != 0) || (ly % 400 == 0); 
                      
            }

            #endregion

        }
    }
}
