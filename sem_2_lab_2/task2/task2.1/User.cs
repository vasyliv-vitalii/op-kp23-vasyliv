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
        public User(string id, string name, int salary, int withheld)
        {
         
        }
        public List<User> ListOfUsers = new List<User>();


        public void PrintUsers()
        {
        

        }
        public void AddUser(User user)
        {
      
        }

        public int SalaryOfUser(string id)
        {
            int salary = 0;

            return salary;
        }

        public void SumOfSalary()
        {
            int sum = 0;
        }

        public void SumOfWithheld()
        {
            int sum = 0;
        }
        public void IssuedMoney()
        {
            int salary = 0;
            int sum = 0;
        }
        public void SumOfUsers()
        {
            Console.WriteLine("number of users:" + ListOfUsers.Count);
        }
        public void ShowInformation(string id)
        {
        }
        public int IssuedMoneyToUser(string id)
        {
            int salary = 0;
            return salary;
        }

        public bool CheckId(string id)
        {
            return false;
        }
    }
}
