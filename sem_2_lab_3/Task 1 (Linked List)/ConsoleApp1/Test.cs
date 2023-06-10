using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Test
    {
        Deque<int> deque;

        public void Tests()
        {
            Console.WriteLine("Add last passed - " + AddLastTest());
            Console.WriteLine("Add first passed - " + AddFirstTest());
            Console.WriteLine("Remove last passed - " + RemoveLastTest());
            Console.WriteLine("Remove first passed - " + RemoveFirstTest());
            IteratorTest();
        }

        private bool AddLastTest()
        {
            deque = new Deque<int>();
            deque.AddLast(1);
            deque.AddLast(2);
            int expected = 2;
            return expected == deque.Size();
        }
        private bool AddFirstTest()
        {
            deque = new Deque<int>();
            deque.AddFirst(1);
            deque.AddFirst(2);
            int expected = 2;
            return expected == deque.Size();
        }

        private bool RemoveFirstTest()
        {
            deque = new Deque<int>();
            deque.AddFirst(1);
            deque.AddFirst(2);
            deque.AddLast(1);
            deque.AddLast(2);
            deque.RemoveFirst();
            int expected = 3;
            return expected == deque.Size();
        }

        private bool RemoveLastTest()
        {
            deque = new Deque<int>();
            deque.AddFirst(1);
            deque.AddFirst(2);
            deque.AddLast(1);
            deque.AddLast(2);
            deque.RemoveLast();
            int expected = 3;
            return expected == deque.Size();
        }

        private void IteratorTest()
        {
            Console.WriteLine("ITERATOR TEST");
            deque = new Deque<int>();
            deque.AddFirst(1);
            deque.AddFirst(2);
            deque.AddLast(1);
            deque.AddLast(2);
            deque.RemoveLast();
            Deque<int>.Iterator iterator = (Deque<int>.Iterator)deque.iterator();
            Console.WriteLine("Actual");
            while (iterator.HasNext)
            {
                Console.Write(iterator.MoveNext() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Expected");
            Console.WriteLine(String.Join(" ", new int[] { 2, 1, 1 }));
        }
    }
}
