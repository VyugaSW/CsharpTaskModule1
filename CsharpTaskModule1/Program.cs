using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTaskModule1
{
    internal class Program
    {
        //Task 1
        static string Task_1(byte n)
        {
            if (n < 1 || n > 100)
                return "Number out of range";
            if (n % 3 == 0 && n % 5 == 0)
                return "Fizz Buzz";
            else if (n % 3 == 0)
                return "Fizz";
            else if (n % 5 == 0)
                return "Buzz";
            else
                return n.ToString();
        }

        //Task 2
        static float Task_2 (float n, float p){
            return n * (p / 100);
         }


        //Task 3
        static int Task_3(int n1, int n2, int n3 , int n4)
        {
            string tempStrNumber = n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString();
            return int.Parse(tempStrNumber);
        }
        


        static void Main(string[] args)
        {
            Console.WriteLine(Task_1(15));
            Console.WriteLine(Task_2(90,10));
            Console.WriteLine(Task_3(1,2,3,4));
        }
    }
}
