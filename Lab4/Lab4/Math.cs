using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Math
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static float Div(int a, int b)
        {

            if(b==0)
            {
                throw new Exception("Can't divide by zero."); 
            }
            return (float)a/b  ;
        }
        public static double Reminder(int a , int b)
        {
            return (double)(a % b); 
        }
    }
}
