using System;


namespace Func4;
public class Program
{
    static void Main()
    {
        int n;
        while (true)
        {
            Console.WriteLine("Enter the number 1 to 9: ");
            n = Convert.ToInt16(Console.ReadLine());
            if (n > 9 || n < 1)
            {
                Console.WriteLine("False number!");
                continue;
            }
            for (int y = 0; y < n; y++)
            {
                int c = 1;
                for (int q = 0; q < n - y; q++)
                {
                    Console.Write("   ");
                }

                for (int x = 0; x <= y; x++)
                {
                    Console.Write("   {0:D} ", c);
                    c = c * (y - x) / (x + 1);
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }

    }
}