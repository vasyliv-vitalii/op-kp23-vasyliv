using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2._3
{
    internal class Submarine : Vessle
    {
        public void PrepareToMove()
        {
            Console.WriteLine("Submarine is preaparing to move");
        }
        public void Move()
        {
            Console.WriteLine("Submarine is moving");
        }
    }
}
