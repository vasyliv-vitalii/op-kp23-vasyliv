using System;

class Program
{
    public static void Main(string[] args)
    {
        /*
         test scenarios
         test 1 
         n = 5 - the number is prime;
         test 2
         n = 40 - the number is not prime;
         test 3
         n = 123 - the number is not prime;
         test 4
         n = 1789 - the number is prime;
         */
        double n;
        Console.WriteLine("����i�� ����� n");
        n = Convert.ToDouble(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("����i�� �������� �����");
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                double res = n % i;

                if (res == 0)
                {
                    Console.WriteLine("�� ����� �� � �������");
                    return;
                }
            }
            Console.WriteLine("����� � �������");
        }

    }
}