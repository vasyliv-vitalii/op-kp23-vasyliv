using Lab3;
class Program
{
    static void Main(string[] args)
    {
        RandomizedQueue<int>.Main();
    }
}
public class RandomizedQueue<Item> 
{
    Item[] queue;
    Item empty;
    List<int> notEmptyCellsIdx;
    public int count;
    Random rnd;
    // construct an empty randomized queue
    public RandomizedQueue()
    {
        queue = new Item[4];
        rnd = new Random();
        notEmptyCellsIdx = new();
    }

    // is the randomized queue empty?
    public bool IsEmpty()
    {
        return count == 0;
    }

    // return the number of items on the randomized queue
    public int Count()
    {
        return count;
    }

    // add the item
    public void Enqueue(Item item)
    {
        for(int i = 0; i < queue.Length; i++)
        {
            if (queue[i].Equals(empty))
            {
                queue[i] = item;
                count++;
                notEmptyCellsIdx.Add(i);
                break;
            }
        }
        if(count == queue.Length)
        {
            Resize(ref queue);
        }
    }

    // remove and return a random item
    public Item Dequeue()
    {
        if (IsEmpty()) throw new Exception("error");
        int idx = notEmptyCellsIdx[rnd.Next(0, notEmptyCellsIdx.Count)];
        notEmptyCellsIdx.Remove(idx);
        Item tmp = queue[idx];
        queue[idx] = empty;
        count--;
        if(count <= queue.Length / 4 && queue.Length > 4)
        {
            Shrink(ref queue);
        }
        return tmp;
    }

    // return a random item (but do not remove it)
    public Item Peek()
    {
        return queue[notEmptyCellsIdx[rnd.Next(0, notEmptyCellsIdx.Count)]];
    }

    public class Iterator
    {
        Item[] iterator;
        List<int> idx;
        Item[] restart_iterator;
        List<int> restart_idx;
        Random rnd;
        public Iterator(Item[] iterator, List<int> idx)
        {
            this.iterator = new Item[iterator.Length];
            Array.Copy(iterator, this.iterator, iterator.Length);
            this.idx = new List<int>(idx);
            restart_iterator = new Item[iterator.Length];
            Array.Copy(iterator, restart_iterator, iterator.Length);
            restart_idx = new List<int>(idx);
            rnd = new Random();
        }
        public bool HasNext => idx.Count > 0;
        public void Reset()
        {
            Array.Copy(restart_iterator, iterator, restart_iterator.Length);
            idx = new List<int>(restart_idx);
        }
        public Item MoveNext()
        {
            int index = idx[rnd.Next(0, idx.Count)];
            Item tmp = iterator[index];
            idx.Remove(index);
            return tmp;
        }
    }

    // return an independent iterator over items in random order
    public Iterator iterator()
    {
        return new Iterator(queue, notEmptyCellsIdx);
    }

    // unit testing (required)
    public static void Main()
    {
        Test test = new();
        test.Tests();
    }

    public void Resize(ref Item[] arr)
    {
        Item[] newarr = new Item[arr.Length * 2];
        for (int i = 0; i < arr.Length; i++)
        {
            newarr[i] = arr[i];
        }
        arr = newarr;
    }
    public void Shrink(ref Item[] arr)
    {
        Item[] newarr = new Item[arr.Length / 2];
        notEmptyCellsIdx.Clear();
        int idx = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (!arr[i].Equals(empty))
            {
                newarr[idx] = arr[i];
                notEmptyCellsIdx.Add(idx++);
            }
        }
        arr = newarr;
    }
}
