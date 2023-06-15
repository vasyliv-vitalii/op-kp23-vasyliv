using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2._3
{
    internal class SailingVessle : Vessle
    {
        public void PrepareToMove()
        {
            Console.WriteLine("Sailing vessle is preaparing to move");
        }

        public void Move()
        {
            Console.WriteLine("Sailing vessle is moving");
        }
    }
}
