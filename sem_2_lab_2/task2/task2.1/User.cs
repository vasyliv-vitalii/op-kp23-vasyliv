using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2._1
{
    internal class User
    {
        private string id;
        private string name;
        private int salary;
        private int withheld;
        public string Id { get => id; }
        public string Name { get => name; }
        public int Salary { get => salary; }
        public int Withheld { get => withheld; }
        public User(string id, string name, int salary, int withheld)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.withheld = withheld;
        }
        public List<User> ListOfUsers = new List<User>();


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
                    Console.WriteLine("user id: " + user.Id + " user's name: " + user.Name + " user's salary: " + user.Salary + " user's withheld: " + user.Withheld);
                }
            }

        }
        public void AddUser(User user)
        {
            try
            {
                var match = ListOfUsers.Single(b => String.Compare(b.Id, user.Id) == 0);
                Console.WriteLine("User already exists");
            }
            catch (InvalidOperationException e)
            {
                ListOfUsers.Add(user);
                Console.WriteLine("user is added");
            };
        }

        public int SalaryOfUser(string id)
        {
            int salary = 0;
            foreach (var item in ListOfUsers)
            {
                if (item.Id == id)
                {
                    salary = item.Salary;
                }
            }
            return salary;
        }

        public void SumOfSalary()
        {
            int sum = 0;
            foreach (var item in ListOfUsers)
            {
                sum += item.Salary;
            }
            Console.WriteLine("sum of salary:" + sum);
        }

        public void SumOfWithheld()
        {
            int sum = 0;
            foreach (var item in ListOfUsers)
            {
                sum += item.Withheld;
            }
            Console.WriteLine("sum of withheld " + sum);
        }
        public void IssuedMoney()
        {
            int salary = 0;
            int sum = 0;
            foreach (var item in ListOfUsers)
            {
                salary = item.Salary - item.Withheld;
                sum += salary;
                salary = 0;
            }
            Console.WriteLine("issued money: " + sum);
        }
        public void SumOfUsers()
        {
            Console.WriteLine("number of users:" + ListOfUsers.Count);
        }
        public void ShowInformation(string id)
        {
            foreach (var item in ListOfUsers)
            {
                if (item.Id == id)
                {
                    Console.WriteLine("user id: " + item.Id + " user's name: " + item.Name + " user's salary: " + item.Salary + " user's withheld: " + item.Withheld);
                }
            }
        }
        public int IssuedMoneyToUser(string id)
        {
            int salary = 0;
            foreach (var item in ListOfUsers)
            {
                if (item.Id == id)
                {
                    salary = item.Salary - item.Withheld;
                }
            }
            return salary;
        }

        public bool CheckId(string id)
        {
            if (ListOfUsers.Count == 0) return false;
            foreach (var item in ListOfUsers)
            {
                if (item.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
