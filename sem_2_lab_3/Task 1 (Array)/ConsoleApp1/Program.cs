using Lab3;
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Deque<int>.main();
    }
}
public class Deque<Item>
{
    Item[] array;
    int r;
    int l;
    int counter;

    // construct an empty deque
    public Deque()
    {
        array = new Item[4];
        l = 1;
        r = 2;
    }

    // is the deque empty?
    public bool IsEmpty()
    {
        return counter == 0;
    }

    // return the number of items on the deque
    public int Count()
    {
        return counter;
    }

    // add the item to the front
    public void AddFirst(Item item)
    {
        array[l--] = item;
        counter++;
        if(l < 0 || array.Length / 4 * 3 < counter)
        {
            Resize(ref array);
        }
    }

    // add the item to the back
    public void AddLast(Item item)
    {
        array[r++] = item;
        counter++;
        if(r >= array.Length || array.Length / 4 * 3 <= counter)
        {
            Resize(ref array);
        }
    }

    // remove and return the item from the front
    public Item RemoveFirst()
    {
        Item tmp = array[l+1];
        array[l+1] = array[l++];
        counter--;
        if (array.Length / 4 >= counter && array.Length > 4)
        {
            Shrink(ref array);
        }
        if(counter == 0)
        {
            l = 1;
            r = 2;
        }
        return tmp;
    }

    // remove and return the item from the back
    public Item RemoveLast()
    {
        Item tmp = array[r - 1];
        array[r - 1] = array[r--];
        counter--;
        if(array.Length / 4 >= counter && array.Length > 4)
        {
            Shrink(ref array);
        }
        if (counter == 0)
        {
            l = 1;
            r = 2;
        }
        return tmp;
    }

    // return an iterator over items in order from front to back
    public IIterator<Item> iterator()
    {
        return new Iterator(array, l, r, counter);
    }

    // unit testing (required)
    public static void main()
    {
        Test test = new Test();
        test.Tests();
    }

    public class Iterator : IIterator<Item>
    {
        Item[] current;
        int left;
        int right;
        int counter;
        public Iterator(Item[] current, int left, int right, int counter)
        {
            this.current = current;
            this.left = left;
            this.right = right;
            this.counter = counter;
        }
        public bool HasNext => counter > 0;

        public Item MoveNext()
        {
            if (left > right) throw new Exception("Daun blyat' nema kudy");
            counter--;
            return current[++left];
        }
    }

    public void Resize(ref Item[] arr)
    {
        Item[] newarr = new Item[arr.Length*2];
        int idx = arr.Length / 2;
        int newL = idx - 1;
        for (int i = l + 1; i < r; i++)
        {
            newarr[idx++] = arr[i];
        }
        arr = newarr;
        l = newL;
        r = idx;
    }
    public void Shrink(ref Item[] arr)
    {
        Item[] newarr = new Item[arr.Length/2];
        int start = newarr.Length / 2 - counter / 2;
        int newL = start - 1;
        for (int i = l + 1; i < r; i++)
        {
            newarr[start++] = arr[i];
        }
        arr = newarr;
        l = newL;
        r = start;
    }
}

public interface IIterator<T>
{
    bool HasNext { get; }
    T MoveNext();
}
