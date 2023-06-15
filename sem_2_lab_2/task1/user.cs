using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task1
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
    }
}
