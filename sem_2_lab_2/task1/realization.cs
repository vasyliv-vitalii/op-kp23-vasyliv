using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace lab2task1
{
    internal class Realization
    {
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
