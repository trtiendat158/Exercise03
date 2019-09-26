using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloob

{
    class Program
    {
        static void Main(string[] args)
        {
            Problem6(4);
            Problem7(4);
        }
        static void Problem6(int n)
        {
            Console.WriteLine("Horizontal line : ");
            DrawHorizontalLine(n, '*');
            Console.WriteLine("Vertical line : ");
            DrawVerticalLine(n, '*');
            Console.WriteLine("Diagonal line : ");
            DrawDiagonalLine(n, '*');
        }

        static void DrawHorizontalLine(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(c);
            }
        }

        static void DrawVerticalLine(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(c);
            }
        }

        static void DrawDiagonalLine(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                DrawHorizontalLine(i - 1, ' ');
                Console.WriteLine(c);
            }
        }

        static void Problem7(int n)
        {
            Console.WriteLine("Isosceles triangle up : ");
            DrawUpIsoscelesTriangle(n, '*');
            Console.WriteLine("N letter : ");
            DrawNLetter(5, '*');
            Console.WriteLine("Isosceles triangle down : ");
            DrawDownIsoscelesTriangle(n, '*');
        }

        static void DrawUpIsoscelesTriangle(int n, char c)
        {
            DrawHorizontalLine(n - 1, ' ');
            Console.WriteLine(c);

            int pre = n - 2, cen = 1;

            for (int i = 1; i <= n - 2; i++)
            {
                DrawHorizontalLine(pre, ' ');
                DrawHorizontalLine(1, c);
                DrawHorizontalLine(cen, ' ');
                DrawHorizontalLine(1, c);
                Console.WriteLine();
                pre -= 1;
                cen += 2;
            }

            DrawHorizontalLine(2 * n - 1, c);
            Console.WriteLine();
        }

        static void DrawNLetter(int n, char c)
        {
            DrawHorizontalLine(1, c);
            DrawHorizontalLine(n - 2, ' ');
            Console.WriteLine(c);

            int pre = 0, next = n - 3;
            for (int i = 1; i <= n - 2; i++)
            {
                DrawHorizontalLine(1, c);
                DrawHorizontalLine(pre, ' ');
                DrawHorizontalLine(1, c);
                DrawHorizontalLine(next, ' ');
                DrawHorizontalLine(1, c);
                Console.WriteLine();
                pre++;
                next--;
            }

            DrawHorizontalLine(1, c);
            DrawHorizontalLine(n - 2, ' ');
            Console.WriteLine(c);
        }

        static void DrawDownIsoscelesTriangle(int n, char c)
        {
            DrawHorizontalLine(2 * n - 1, c);
            Console.WriteLine();

            int pre = 1, cen = 2 * n - 5;
            for (int i = 1; i <= n - 2; i++)
            {
                DrawHorizontalLine(pre, ' ');
                DrawHorizontalLine(1, c);
                DrawHorizontalLine(cen, ' ');
                DrawHorizontalLine(1, c);
                Console.WriteLine();
                pre += 1;
                cen -= 2;
            }

            DrawHorizontalLine(n - 1, ' ');
            Console.WriteLine(c);
            //
        }
    }
}


