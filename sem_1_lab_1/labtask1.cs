class Programm
{
    static void Main(string[] args)
    {
        /*
        test scenarios
        test1 x = 5,3 , y = 201,12279953882054;
        test2 x = 5,55 , y = 230,87287945419033;
        test3 x = 5,8 , y = 230,87287945419033;
        test4 x = 6,05 , y = 298,95585864547627;
        test5 x = 6,3 , y = 337,6281553330734;
         */
        double a = 1.35;
        double b = -6.25;
        double dx = 0.25;
        Console.WriteLine("Enter x0");
        double x0 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter xk");
        double xk = Convert.ToDouble(Console.ReadLine());
        double y, x;
        for (double i = x0; i <= xk; i += dx)
        {
            x = i;
            y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);

            Console.WriteLine("x = " + x + "   " + "y = " + y);
        }
    }


}
