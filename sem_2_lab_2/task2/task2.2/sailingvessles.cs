using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2._2
{
    internal class SailingVessel : vessles
    {
        public override void PreaparingToMove()
        {
            Console.WriteLine("Sailing vessel is preaparing to move");
        }
        public override void Move()
        {
            Console.WriteLine("Sailing vessel is moving");
        }
    }
}
