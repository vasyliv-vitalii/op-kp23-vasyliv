using System;

class Programm
{
    static void Main(string[] args)
    {
        /*
        test scenarios
        test 1
        x = 1 , a = 7 : sin = 0,8414709848078937;
        test 2
        x = 4 , a = 7 : sin = -0,7568024953079282;
        test 3
        x = 141 , a = 7 : sin = 0,36317127391807535;
        test 4
        x = 6 , a = 7 : sin = -0,2794153423357333;
        test 5
        x = 10 , a = 7 : sin = -0,54402111088937;
        */
        double x;
        double a;
        double sin = 0;
        Console.WriteLine("Enter the number x");
        bool isxcorrect = double.TryParse(Console.ReadLine(), out x);
        Console.WriteLine("Enter the number a");
        bool isacorrect = double.TryParse(Console.ReadLine(), out a);
        if (!isxcorrect)
        {
            Console.WriteLine("Enter correct x");
        }
        if (!isacorrect)
        {
            Console.WriteLine("Enter correct a");
        }
        int sign = Math.Floor(x / Math.PI) % 2 == 0 ? 1 : -1;
        x %= Math.PI;
        for (int i = 0; i <= a; i++)
        {
            sin += Power(-1, i) * (Power(x, 2 * i + 1) / Factorial(2 * i + 1));
        }
        Console.WriteLine(sin * sign);
    }
    static double Power(double numb, double n)
    {
        double res = 1;
        for (int i = 0; i < n; i++)
        {
            res *= numb;
        }
        return res;
    }
    static double Factorial(double numb)
    {
        double factorial = 1;
        for (double i = 1; i <= numb; i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
}