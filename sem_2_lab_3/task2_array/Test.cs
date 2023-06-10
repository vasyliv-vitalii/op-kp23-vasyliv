using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Test
    {
        RandomizedQueue<int> randomizedQueue = new RandomizedQueue<int>();

        public void Tests()
        {
            Console.WriteLine($"Count tests passed? {CountTest()}");
            AllElementsExist();
            DifferentOutput();
        }

        public bool CountTest()
        {
            int expected1 = 0;
            int expected2 = 1;
            int expected3 = 2;
            int expected4 = 1;
            int expected5 = 0;
            int actual1 = randomizedQueue.count;
            randomizedQueue.Enqueue(1);
            int actual2 = randomizedQueue.count;
            randomizedQueue.Enqueue(2);
            int actual3 = randomizedQueue.count;
            randomizedQueue.Dequeue();
            int actual4 = randomizedQueue.count;
            randomizedQueue.Dequeue();
            int actual5 = randomizedQueue.count;
            if (actual1 != expected1)
            {
                Console.WriteLine("TEST 1 : FAILED");
                return false;
            }
            if (actual2 != expected2)
            {
                Console.WriteLine("TEST 2 : FAILED");
                return false;
            }
            if (actual3 != expected3)
            {
                Console.WriteLine("TEST 3 : FAILED");
                return false;
            }
            if (actual4 != expected4)
            {
                Console.WriteLine("TEST 4 : FAILED");
                return false;
            }
            if (actual5 != expected5)
            {
                Console.WriteLine("TEST 5 : FAILED");
                return false;
            }
            return true;
        }

        private bool AllElementsExist()
        {
            List<int> elements = new List<int>();
            elements.Add(1);
            elements.Add(2);
            elements.Add(100);
            randomizedQueue.Enqueue(1);
            randomizedQueue.Enqueue(2);
            randomizedQueue.Enqueue(100);
            RandomizedQueue<int>.Iterator iterator = randomizedQueue.iterator();
            Console.WriteLine("Queue elements :");
            while (iterator.HasNext)
            {
                Console.Write(iterator.MoveNext() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("All elements");
            Console.WriteLine(String.Join(" ", elements));
            return true;
        }

        private void DifferentOutput()
        {
            randomizedQueue = new RandomizedQueue<int>();
            randomizedQueue.Enqueue(1);
            randomizedQueue.Enqueue(2);
            randomizedQueue.Enqueue(3);
            randomizedQueue.Enqueue(4);
            RandomizedQueue<int>.Iterator iterator = randomizedQueue.iterator();
            Console.WriteLine("Queue elements :");
            while (iterator.HasNext)
            {
                Console.Write(iterator.MoveNext() + " ");
            }
            iterator.Reset();
            Console.WriteLine();
            Console.WriteLine("Queue elements :");
            while (iterator.HasNext)
            {
                Console.Write(iterator.MoveNext() + " ");
            }
        }
    }
}
