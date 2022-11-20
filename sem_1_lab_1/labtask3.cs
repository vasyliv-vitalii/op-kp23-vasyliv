class Program
{
    static void Main(string[] args)
    {
        /*
        test scenarios 
        test 1 
        n = 1 , x = 2 : result - x^n = 1 , fatorial = 1;
        test 2 
        n = 5 , x = 6 : result - x^n = 7776 , fatorial = 120;
        test 3 
        n = 10 , x = 4 : result - x^n = 1048576 , fatorial = 1;
        test 4 
        n = -5 , x = 4 : result - x^n = 0,0009765625 , fatorial = answer doesn't exist;
        test 5 
        n = 4 , x = -2 : result - x^n = 16 , fatorial = 24;
        */
        int n, x;
        Console.WriteLine("¬ведiть число n");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("¬ведiть число x");
        x = Convert.ToInt32(Console.ReadLine());
        double res = Math.Pow(x, n);
        Console.WriteLine("«наченн€ х в степенi n дорiвнюЇ " + res);
        double factorial = 1;
        if (n < 0)
        {
            Console.WriteLine("¬ведiть коректне число n");
            return;
        }
        else
        {
            for (double i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("‘акторiал з " + n + " доiвнюЇ " + factorial);
        }
    }
}
