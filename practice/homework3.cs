using System;

namespace Func3
{
    class Program
    {

        static void Main(string[] arg)
        {
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;
            Console.WriteLine("Enter value for x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y2:");
            y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("The length of vector is " + length);
        }
    }
}