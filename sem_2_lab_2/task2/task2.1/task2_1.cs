using lab2task2._1;

class MyClass
{
    static void Main(string[] args)
    {
        User admin = new User("", "", 0, 0);

        Console.WriteLine("write /start - to start work ");
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
                case "/add":
                    {
                        Console.WriteLine("Write information about user:1) user id;2)user name;3)user's salary 4) user's withheld");
                        admin.AddUser(new User(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                        Console.WriteLine("press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/print":
                    {
                        admin.PrintUsers();
                        Console.WriteLine("press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/showinformation":
                    {
                        Console.WriteLine("write id of user");
                        string id = Console.ReadLine();
                        if (admin.CheckId(id) == true)
                        {
                            admin.ShowInformation(id);
                        }
                        else
                        {
                            Console.WriteLine("no such id exists");
                        }
                        Console.WriteLine("press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/sumofusers":
                    {
                        admin.SumOfUsers();
                        Console.WriteLine("press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/salaryofuser":
                    {
                        Console.WriteLine("write id of user");
                        string id = Console.ReadLine();
                        if (admin.CheckId(id) == true)
                        {
                            Console.WriteLine("user's salary :  " + admin.SalaryOfUser(id));
                        }
                        else
                        {
                            Console.WriteLine("no such id exists");
                        }
                        Console.WriteLine("press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/issuedmoneytouser":
                    {
                        Console.WriteLine("write id of user");
                        string id = Console.ReadLine();
                        if (admin.CheckId(id) == true)
                        {
                            Console.WriteLine("issued money : " + admin.IssuedMoneyToUser(id));
                        }
                        else
                        {
                            Console.WriteLine("no such id exists");
                        }
                        Console.WriteLine("press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/sumofsalary":
                    {
                        admin.SumOfSalary();
                        Console.WriteLine("press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/sumofwithheld":
                    {
                        admin.SumOfWithheld();
                        Console.WriteLine("press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/issuedmoney":
                    {
                        admin.IssuedMoney();
                        Console.WriteLine("press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "/close":
                    {
                        Console.WriteLine("Thank you for using my app");
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Write correct command!!!");
                        Console.WriteLine("press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
            }
            Start();
        }
        static void Start()
        {
            Console.WriteLine("if you want add user write - /add");
            Console.WriteLine("if you want list of users write - /print");
            Console.WriteLine("if you want see informatio about certain user write - /showinformation");
            Console.WriteLine("if you want see number of user write - /sumofusers");
            Console.WriteLine("if you want see user's salary write -/salaryofuser");
            Console.WriteLine("if you want to see how much has been paid out to a user write - /issuedmoneytouser");
            Console.WriteLine("if you want sum of users' salary write - /sumofsalary");
            Console.WriteLine("if you want to see how much money you have withheld write - /sumofwithheld");
            Console.WriteLine("if you want to see how much has been paid out to a users write - /issuedmoney ");
            Console.WriteLine("if you want see list of command write - /command ");
            Console.WriteLine("if you want close programm - /close");
        }
    }

}