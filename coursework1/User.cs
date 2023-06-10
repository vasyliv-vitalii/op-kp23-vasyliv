using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursova
{
    class User
    {
        protected string name;
        protected string password;
        protected string email;
        public string Email { get => email; }
        public string Password { get => password; }
        public string Name { get => name; }
        public List<string> favourites = new List<string>();
        public User(string name, string email, string password)
        {
            this.name = name;
            this.password = password;
            this.email = email;
            this.favourites = new List<string>();
        }
        public void ChangePassword()
        {
            while (true)
            {
                Console.WriteLine("Write your new password");
                string tmp = Console.ReadLine();
                Console.WriteLine("Write new password again");
                string newpass = Console.ReadLine();
                if (tmp == newpass)
                {
                    Console.WriteLine("Password was changed");
                    password = newpass;
                    break;
                }
                else
                {
                    Console.WriteLine("Write correct password");
                }
            }

        }
        public void ChangeNmae()
        {
            Console.WriteLine("Write your new name");
            string tmp = Console.ReadLine();
            name = tmp;
            Console.WriteLine("Name was changed");
        }
        public void ChangeNmae(string name)
        {
            this.name = name;
            Console.WriteLine("Name was changed");
        }
        public void ChangeEmail()
        {
            Console.WriteLine("Write your password");
            string tmp = Console.ReadLine();
            if (tmp == password)
            {
                Console.WriteLine("Write new email");
                email = Console.ReadLine();
                Console.WriteLine("Email was changed");
            }
            else
            {
                Console.WriteLine("Write correct password.");
            }

        }
    }
}
