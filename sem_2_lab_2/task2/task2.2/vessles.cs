using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2._2
{
    abstract class vessles
    {
        public virtual void PreaparingToMove()
        {
            Console.WriteLine("vessle is preaparing to moving");
        }

        public virtual void Move()
        {
            Console.WriteLine("vessle is  moving");
        }
    }
}