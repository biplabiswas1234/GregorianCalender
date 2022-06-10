using System;
using System.Collections.Generic;
using System.Text;

namespace GregorianCalender
{
    internal class Calender
    {
        public  void DateTime()
        {
            Console.WriteLine("Enter day number");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month number");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            int y = Convert.ToInt32(Console.ReadLine());
            int y0 = y - (14 - m)/12;
            int x = y0 + y0/4 - y0/100 + y0/400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = ((d + x + 31 * m0 / 12) % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("saturday");
                    break;

            }
        }
    }
}
