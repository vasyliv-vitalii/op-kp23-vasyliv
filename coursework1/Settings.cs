using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace cursova
{
    class Settings
    {
        public static void ChangeSattings(User user)
        {
            realizationforuser inst = new realizationforuser();
            Console.WriteLine("If you want to change something write command from list.");
            Console.WriteLine("Write /commnds  - to check the list of commands.");
            while (true)
            {
                string command = Console.ReadLine();
                switch (command )
                {
                    case "/commands":
                        {
                            Console.Clear();
                            break;
                        }
                    case "/changepass":
                        {
                            Console.Clear();
                            user.ChangePassword();
                            Thread.Sleep(2500);
                            Console.Clear();
                            inst.Update();
                            break;
                        }
                    case "/changename":
                        {
                            Console.Clear();
                            user.ChangeNmae();
                            Thread.Sleep(2500);
                            Console.Clear();
                            break;
                        }
                    case "/changeemail":
                        {
                            Console.Clear();
                            user.ChangeEmail();
                            Thread.Sleep(2500);
                            Console.Clear();
                            break;
                        }
                    case "/close":
                        {
                            Console.Clear();
                            return;
                        }
                    default:
                        Console.Clear();
                        Console.WriteLine("write correct command");
                        Thread.Sleep(2500);
                        Console.Clear();
                        break;
                }
                ListofCommand();
            }
        }

        public static void ListofCommand()
        {
            Console.WriteLine("If you want to check list of command - /commands");
            Console.WriteLine("If you want to change name - /changename");
            Console.WriteLine("If you want to change name - /changename");
            Console.WriteLine("If you want to change email - /changeemail");
            Console.WriteLine("If tou want to close settings - /close");
        }
    }
}
