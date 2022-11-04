using System;

namespace Func2
{
    class Program
    {

        static void Main(string[] arg)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            Console.WriteLine("Enter value for a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        double p = (a + b + c) / 2;
                        double sum = Math.Sqrt(p * (p - a) * (p - c) * (p - b));
                        Console.WriteLine(" The area of ​​a triangle according to the Heron formula " + sum);
                    }
                    else
                    {
                        Console.WriteLine("The change c must be positive");
                    }
                }
                else
                {
                    Console.WriteLine("The change b must be positive");
                }
            }
            else
            {
                Console.WriteLine("The change a must be positive");
            }

        }
    }
}