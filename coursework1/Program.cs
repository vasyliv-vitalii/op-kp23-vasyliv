using cursova;
using System;
using System.Threading;
class MyClass
{
    static void Main(string[] args)
    {
        realizationforuser inst = new realizationforuser();
        inst.LoadData();
        Console.WriteLine("Hello,user!");
        Console.WriteLine("Its our 'Directory of proverbs'");
        Console.WriteLine("Pleasant use!!!");
        Console.WriteLine("----press enter to continue----");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Write /start - to start work with our APi");
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
                case "/reg":
                    {
                        Console.Clear();
                        Console.WriteLine("Write information abouct you.");
                        Console.WriteLine("Write your last name.");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Write your email.");
                        string email = Console.ReadLine();
                        Console.WriteLine("Write your password");
                        string password = Console.ReadLine();
                        Console.Clear();
                        inst.AddUser(new User(lastname, email, password));
                        Console.WriteLine("----press enter to continue----");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/all":
                    {
                        Console.Clear();
                        inst.PrintUsers();
                        Console.WriteLine("----press enter to continue----");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/login":
                    {
                        Console.Clear();
                        Console.WriteLine("Write your email");
                        string email = Console.ReadLine();
                        Console.WriteLine("Write your password");
                        string password = Console.ReadLine();
                        Console.Clear();
                        User user = inst.Login(email,password);
                        Console.Clear();
                        if (user != null)
                        {
                            Console.WriteLine("Login to the account is completed");
                            Thread.Sleep(2500);
                            Console.Clear();
                            afterlogin aftlog = new afterlogin();
                            aftlog.AfterLogin(user);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("You entered the wrong password or email.");
                            Console.WriteLine("----press enter to continue----");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    }
                case "/close":
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for using our app!!!");
                        inst.Update();
                        return;
                    }
                default:
                    Console.Clear();
                    Console.WriteLine("write correct command");
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;  
            }
            Start();
        }
    }

    public static void Start()
    {
        Console.WriteLine("List of command:");
        Console.WriteLine("/reg - registration in our app");
        Console.WriteLine("/login - account login");
        Console.WriteLine("/all - list of registered");
        Console.WriteLine("/close - closing the program ");
    }
}