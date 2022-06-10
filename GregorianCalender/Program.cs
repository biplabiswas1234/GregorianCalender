using System;

namespace GregorianCalender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gregorian calender!");
            Calender calender = new Calender();
            calender.DateTime();
        }
    }
}
