namespace hashtable
{
    public class HashTable<KItem, VItem>
    {
        KeyValuePairs<KItem, VItem>[] items;
        int capacity;
        int count;
        public HashTable(int intialCapacity)
        {
            capacity = intialCapacity;
            items = new KeyValuePairs<KItem, VItem>[capacity];
        }

        private int GetFirstHashIndex(KItem key)
        {
            int idx = key.GetHashCode();
            idx %= capacity;
            if(idx < 0)
                idx = Math.Abs(idx);
            return idx;
        }

        private int GetSecondHashIndex(KItem key)
        {
            int idx = key.GetHashCode();
            idx %= capacity;
            if (idx < 0)
                idx = Math.Abs(idx);
            idx = idx == 0 ? 1 : idx;
            int pow = 0;
            int num = idx;
            while(num > 0)
            {
                num /= 2;
                pow++;
            }
            return pow - idx % pow;
        }

        public void Add(KItem key, VItem value)
        {
            if (count == capacity) throw new Exception("HashTable is full!");
            int hash1 = GetFirstHashIndex(key);
            int hash2 = GetSecondHashIndex(key);
            while (items[hash1] != null)
            {
                hash1 += hash2;
                hash1 %= capacity;
            }
            items[hash1] = new KeyValuePairs<KItem, VItem>(key, value);
            count++;
        }

        public void Remove(KItem key)
        {
            int hash1 = GetFirstHashIndex(key);
            int hash2 = GetSecondHashIndex(key);
            while (items[hash1] != null && !items[hash1].key.Equals(key))
            {
                hash1 += hash2;
                hash1 %= capacity;
            }
            items[hash1] = null;
            count--;
        }

        public VItem Get(KItem key)
        {
            int hash1 = GetFirstHashIndex(key);
            int hash2 = GetSecondHashIndex(key);
            while (items[hash1] != null && !items[hash1].key.Equals(key))
            {
                hash1 += hash2;
                hash1 %= capacity;
            }
            return items[hash1].value;
        }

        public bool Contains(KItem key)
        {
            int hash1 = GetFirstHashIndex(key);
            int hash2 = GetSecondHashIndex(key);
            for(int i = 0; i < capacity; i++)
            {
                if(items[hash1] != null && items[hash1].key.Equals(key))
                    return true;
                hash1 += hash2;
                hash1 %= capacity;
            }
            return false;
        }

        public void Clear()
        {
            items = new KeyValuePairs<KItem, VItem>[capacity];
        }

        public int Size()
        {
            return count;
        }

        public void PrintHashTable()
        {
            foreach(var item in items)
            {
                if(item != null)
                    Console.WriteLine($"Key: {item.key};\tValue: {item.value}");
            }
            Console.WriteLine();
        }
    }
}
