using System.Diagnostics;
using Lab3;
class Program
{
    static void Main(string[] args)
    {
        Deque<int>.main();
    }
}
public class Node<T>
{
    public T item;
    public Node<T> left;
    public Node<T> right;
    public Node(Node<T> left = null, Node<T> right = null)
    {
        this.left = left;
        this.right = right;
    }
}
public class Deque<Item>
{
    int Lcounter;
    int Rcounter;
    Node<Item> left;
    Node<Item> right;

    // construct an empty deque
    public Deque()
    {
        left = new Node<Item>();
        right = new Node<Item>(left, null);
        left.right = right;
        Lcounter = 0;
        Rcounter = 0;
    }

    // is the deque empty?
    public bool IsEmpty()
    {
        return Lcounter + Rcounter == 0;
    }

    // return the number of items on the deque
    public int Size()
    {
        return Lcounter + Rcounter;
    }

    // add the item to the front
    public void AddFirst(Item item)
    {
        if(Lcounter > 0)
        {
            left.left = new Node<Item>(null, left);
            left.left.item = item;
            left = left.left;
        }
        else
        {
            left.item = item;
        }
        Lcounter++;
    }

    // add the item to the back
    public void AddLast(Item item)
    {
        if(Rcounter > 0)
        {
            right.right = new Node<Item>(right, null);
            right.right.item = item;
            right = right.right;
        }
        else
        {
            right.item = item;
        }
        Rcounter++;
    }

    // remove and return the item from the front
    public Item RemoveFirst()
    {
        if (IsEmpty())
        {
            throw new Exception("error");
        }
        Item tmp = left.item;
        left = left.right;
        if(left != null)
            left.left = null;
        Lcounter--;
        return tmp;
    }

    // remove and return the item from the back
    public Item RemoveLast()
    {
        if (IsEmpty())
        {
            throw new Exception("error");
        }
        Item tmp = right.item;
        right = right.left;
        if (right != null)
            right.right = null;
        Lcounter--;
        return tmp;
    }

    // return an iterator over items in order from front to back
    public IIterator<Item> iterator()
    {
        return new Iterator(left);
    }

    // unit testing (required)
    public static void main()
    {
        Test test = new();
        test.Tests();
    }
    public class Iterator : IIterator<Item>
    {
        Node<Item> current;
        public Iterator(Node<Item> current)
        {
            this.current = current;
        }
        public bool HasNext => current != null;
        
        public Item MoveNext()
        {
            if (current == null) throw new Exception("error");
            var tmp = current.item;
            current = current.right;
            return tmp;
        }
    }
}
public interface IIterator<T>
{
    public bool HasNext { get; }
    T MoveNext();
}
