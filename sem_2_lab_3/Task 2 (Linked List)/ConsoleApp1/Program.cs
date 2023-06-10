using Lab3;

class Program
{
    static void Main(string[] args)
    {
        RandomizedQueue<int>.Main();
    }
}
public class Node<Item>
{
    public Item item;
    public Node<Item> next;

    public Node(Node<Item> next = null)
    {
        this.next = next;
    }
}
public class RandomizedQueue<Item>  
{
    public Node<Item> queue;
    public Node<Item> pointer;
    public int count;
    public Random rnd;

    // construct an empty randomized queue
    public RandomizedQueue()
    {
        queue = new Node<Item>();
        pointer = queue;
        rnd = new Random();
    }

    // is the randomized queue empty?
    public bool IsEmpty()
    {
        return count == 0;
    }

    // return the number of items on the randomized queue
    public int Size()
    {
        return count;
    }

    // add the item
    public void Enqueue(Item item)
    {
        if(count == 0)
        {
            pointer.item = item;
            count++;
        }
        else
        {
            pointer.next = new Node<Item>();
            pointer.next.item = item;
            pointer = pointer.next;
            count++;
        }
    }

    // remove and return a random item
    public Item Dequeue()
    {
        pointer = queue;
        int idx = rnd.Next(0, count);
        count--;
        if(idx == 0)
        {
            Item temp = pointer.item;
            queue = queue.next;
            return temp;
        }
        for(int i = 0; i < idx - 1; i++)
        {
            pointer = pointer.next;
        }
        Item tmp = pointer.next.item;
        pointer.next = pointer.next.next;
        return tmp;
    }

    // return a random item (but do not remove it)
    public Item Peek()
    {
        pointer = queue;
        int idx = rnd.Next(0, count);
        if (idx == 0)
        {
            return pointer.item;
        }
        for (int i = 0; i < idx - 1; i++)
        {
            pointer = pointer.next;
        }
        return pointer.next.item;
    }

    public class Iterator
    {
        Node<Item> queue;
        Node<Item> pointer;
        List<Item> items = new();
        int count;
        Random rnd;
        public Iterator(Node<Item> queue, Node<Item> pointer, int count)
        {
            this.queue = queue;
            this.pointer = pointer;
            this.count = count;
            rnd = new Random();
        }
        public bool HasNext => queue != null && count >= 0;
        public void Reset()
        {
            count = items.Count;
            queue = pointer;
            pointer.item = items[0];
            for(int i = 1; i < items.Count; i++)
            {
                pointer.next = new Node<Item>();
                pointer.next.item = items[i];
                pointer = pointer.next;
            }
        }
        public Item MoveNext()
        {
            if (queue == null || count < 0) throw new Exception("Blyat' dima pizdec");
            pointer = queue;
            int idx = rnd.Next(0, count);
            count--;
            if (idx == 0)
            {
                Item temp = pointer.item;
                queue = queue.next;
                items.Add(temp);
                return temp;
            }
            for (int i = 0; i < idx - 1; i++)
            {
                pointer = pointer.next;
            }
            Item tmp = pointer.next.item;
            items.Add(tmp);
            pointer.next = pointer.next.next;
            return tmp;
        }
    }

    // return an independent iterator over items in random order
    public Iterator iterator()
    {
        return new Iterator(queue, pointer, count);
    }

    // unit testing (required)
    public static void Main()
    {
        Test test = new();
        test.Tests();
    }
}