using lab2task2._2;

class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("/start to work with app");
        while (true)
        {
            string command = Console.ReadLine();
            switch (command)
            {
                case "/start":
                case "/command":
                    {
                        Console.Clear();
                        break;
                    }
                case "/submarine":
                    {
                        Console.Clear();
                        vessles v1 = new submarine();
                        Thread.Sleep(1500);
                        v1.PreaparingToMove();
                        Thread.Sleep(1500);
                        v1.Move();
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/sailing":
                    {
                        Console.Clear();
                        vessles v1 = new SailingVessel();
                        Thread.Sleep(1500);
                        v1.PreaparingToMove();
                        Thread.Sleep(1500);
                        v1.Move();
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/close":
                    {
                        Console.WriteLine("Thank you for using my app!!!");
                        return;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Write correct command!!!");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                    }
            }
            Start();
        }

        static void Start()
        {
            Console.WriteLine("if you want to cheack list of command write - /command");
            Console.WriteLine("if you want to take submarine write - /submarine");
            Console.WriteLine("if you want to take sailing vessle - /sailing");
            Console.WriteLine("if you want  to close app  write - /close");
        }
    }
}