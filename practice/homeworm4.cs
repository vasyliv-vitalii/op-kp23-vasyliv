using System;

class HelloWorld
{

    const byte num_digits = 4;

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double cub_a = 1, cal_a = 0;
        double l = 1, r = a, e = 1;
        for (int i = 0; i < num_digits; i++)
        {
            e /= 10;
        }

        do
        {
            cub_a = (l + r) / 2;
            cal_a = cub_a * cub_a * cub_a;
            if (cal_a > a)
            {
                r = cub_a;
            }
            else
            {
                l = cub_a;
            }
        } while (Math.Abs(a - cal_a) > e);


        Console.WriteLine(String.Format("{0:F" + num_digits + "}", cub_a));

    }
}
