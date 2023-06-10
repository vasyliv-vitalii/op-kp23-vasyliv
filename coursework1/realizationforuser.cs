using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cursova
{
    class realizationforuser
    {
        public List<User> ListOfUsers = new List<User>();
        public void Update()
        {
            string path = "D:\\123232323\\cursova\\cursova\\users.csv";
            var sw = new StreamWriter(path);
            foreach (var item in ListOfUsers)
            {
                sw.WriteLine(item.Name + "," + item.Email + "," + item.Password);
            }
            sw.Close();
        }
        public void LoadData()
        {
            string path = "D:\\123232323\\cursova\\cursova\\users.csv";
            var sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                var data = line.Split(',');
                User user = new User(data[0], data[1], data[2]);
                ListOfUsers.Add(user);
            }
            sr.Close();
        }
        public void PrintUsers()
        {
            if (ListOfUsers.Count == 0)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                foreach (User user in ListOfUsers)
                {
                    Console.WriteLine("List of users: ");
                    Console.WriteLine(" user's name: " + user.Name + " user's email: " + user.Email + " user's password:" + Сipher(user.Password));
                }
            }

        }
        public void AddUser(User user)
        {
            string path = "D:\\123232323\\cursova\\cursova\\users.csv";
            try
            {
                var match = ListOfUsers.Single(b => String.Compare(b.Email, user.Email) == 0);
                Console.WriteLine("User already exists");
            }
            catch (InvalidOperationException e)
            {
                ListOfUsers.Add(user);
                Console.WriteLine("user is added");
                var sw = new StreamWriter(path);
                foreach (var item in ListOfUsers)
                {
                    sw.WriteLine(item.Name + "," + item.Email + "," + item.Password);
                }
                sw.Close();
            };

        }

        public string Сipher(string password)
        {
            string answer = "";
            foreach (var item in password)
            {
                answer += "*";
            }
            return answer;
        }
        public void ListOffavourites(User user)
        {
            foreach (var item in user.favourites)
            {
                Console.WriteLine(item);
            }
        }

        public User Login(string emails, string paswords)
        {
            foreach (var item in ListOfUsers)
            {
                if (item.Email == emails)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
