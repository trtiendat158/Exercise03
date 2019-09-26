using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input day,month,year you want: ");
            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Xuatngay(day, month, year);
        }
        static void Xuatngay(int day, int month, int year)
        {
            Console.Write("Number of days from 1/1 to {0}/{1}/{2} is:  ", day, month, year);
            Console.Write(CountDay(day, month, year));
        }
        static int CountDay(int day, int month, int year)
        {
            int NumberOfDay = 0;
            int Dayofyear;
            if (year % 4 == 0) Dayofyear = 366;
            else Dayofyear = 365;
            switch (month)
            {
                case 12:
                    NumberOfDay = Dayofyear - 31 + day;
                    break;
                case 11:
                    NumberOfDay = Dayofyear - 31 - 30 + day;
                    break;
                case 10:
                    NumberOfDay = Dayofyear - 31 - 30 - 31 + day;
                    break;
                case 9:
                    NumberOfDay = Dayofyear - 31 - 30 - 31 - 30 + day;
                    break;
                case 8:
                    NumberOfDay = Dayofyear - 31 - 30 - 31 - 30 - 31 + day;
                    break;
                case 7:
                    NumberOfDay = Dayofyear - 31 - 30 - 31 - 30 - 31 - 31 + day;
                    break;
                case 6:
                    NumberOfDay = Dayofyear - 31 - 30 - 31 - 30 - 31 - 31 - 30 + day;
                    break;
                case 5:
                    NumberOfDay = Dayofyear - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 + day;
                    break;
                case 4:
                    NumberOfDay = Dayofyear - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - 30 + day;
                    break;
                case 3:
                    NumberOfDay = Dayofyear - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - 30 - 31 + day;
                    break;
                case 2:
                    if (year % 4 == 0) NumberOfDay = Dayofyear - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - 30 - 31 - 28 + day;
                    else NumberOfDay = Dayofyear - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - 30 - 31 - 29 + day;
                    break;
                case 1:
                    if (year % 4 == 0) NumberOfDay = Dayofyear - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - 30 - 31 - 28 - 31 + day;
                    else NumberOfDay = Dayofyear - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - 30 - 31 - 29 - 31 + day;
                    break;
            }
            return NumberOfDay;
        }
    }
}
