using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2._3
{
    internal interface Vessle
    {
        void PrepareToMove()
        {
            Console.WriteLine("Vessle is preapering to move");
        }
        void Move()
        {
            Console.WriteLine("Vessle is moving");
        }
    }
}
