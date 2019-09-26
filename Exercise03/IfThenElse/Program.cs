using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfThenElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Input number you want to check: ");
            int n = int.Parse(Console.ReadLine());
            Problem2(n);

            Console.WriteLine("\n");
            Console.WriteLine("Input number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number c: ");
            int c = int.Parse(Console.ReadLine());
            Problem3(a, b, c);

            Console.WriteLine("Input your score: ");
            int d = int.Parse(Console.ReadLine());
            Problem4(d);

        }

        static void Problem2(int n)
        {
            if (IsOdd(n))
                Console.WriteLine("{0} is odd number", n);
            if (IsEven(n))
                Console.WriteLine("{0} is even number", n);
        }

        static bool IsOdd(int n)
        {
            return n % 2 == 1;
        }
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        static void Problem3(int a, int b, int c)
        {
            int max = FindMaximum(a, b, c);
            int min = FindMinimum(a, b, c);
            int med = FindMedium(a, b, c);
            Console.WriteLine("{0} is maximum between {1}, {2}, {3}", max, a, b, c);
            Console.WriteLine("{0} is minimum between {1}, {2}, {3}", min, a, b, c);
            Console.WriteLine("{0} is medium between {1}, {2}, {3}", med, a, b, c);

        }
        //set: a,b,c
        //criteria: a/b/c > max
        //action: max = a/b/c
        static int FindMaximum(int a, int b, int c)
        {
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            return max;

            //**Cach khac:

            //int[] temp = { a, b, c };
            //int max = temp[0];
            //for(int i=0; i<temp.Length;i++)
            //{
            //    if(temp[i]>max)
            //    {
            //        max = temp[i];
            //    }
            //}
            //return max;
        }
        static int FindMedium(int a, int b, int c)
        {
            int med = a;
            if (a < b && b < c)
                med = b;
            if (a > b && b > c)
                med = b;
            if (a < c && c < b)
                med = c;
            if (a > c && c > b)
                med = c;
            return med;

            //**Cach khac 1:

            //return a + b + c - FindMaximum(a, b, c) - FindMinimum(a, b, c);

            //**Cach khac 2:

            //int[] temp = { a, b, c };
            //Array.Sort(temp);
            //return temp[1];
        }
        static int FindMinimum(int a, int b, int c)
        {
            int min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            return min;

            // **Cach khac:

            //int[] temp = { a, b, c };
            //int min = temp[0];
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    if(temp[i]<min)
            //    {
            //        min = temp[i];
            //    }
            //}
            //return min;
        }

        static void Problem4(int d)
        {
            if (90 <= d && d <= 100)
            {
                Console.WriteLine("Your Grade: A");
            }
            else if (80 <= d && d <= 90)

            {
                Console.WriteLine("Your Grade: B");
            }
            else if (70 <= d && d <= 80)

            {
                Console.WriteLine("Your Grade: C");
            }
            else if (60 <= d && d <= 70)

            {
                Console.WriteLine("Your Grade: D");
            }
            else
            {
                Console.WriteLine("Your Grade: F");
            }
        }
    }
}
