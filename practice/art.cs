using System;
class Homework
{
    static public void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Enter correct number");
                continue;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    string c = "";
                    string s = "";

                    for (int j = 0; j < i * 4; j++)
                    {
                        c += ".";
                    }
                    for (int j = (n - i - 2) * 2; j >= 0; j--)
                    {
                        s += " ";
                    }
                    Console.Write(s + "|<>");
                    Console.WriteLine(c + "<>|");
                }
                for (int i = n - 1; i >= 0; i--)
                {
                    string c = "";
                    string s = "";
                    for (int j = 0; j < i * 4; j++)
                    {
                        c += ".";
                    }
                    for (int j = 0; j <= (n - i - 2) * 2; j++)
                    {
                        s += " ";
                    }
                    Console.Write(s + "|<>");
                    Console.WriteLine(c + "<>|");
                }
            }
        }

    }
}