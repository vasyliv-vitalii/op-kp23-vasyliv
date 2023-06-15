using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2._2
{
    class submarine : vessles
    {
        public override void PreaparingToMove()
        {
            Console.WriteLine("Submarine is preaparing to move");
        }
        public override void Move()
        {
            Console.WriteLine("Sibmarine is moving");
        }
    }
}
