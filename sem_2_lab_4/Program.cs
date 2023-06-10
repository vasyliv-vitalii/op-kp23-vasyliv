using hashtable;
class Program
{
    static void Main(string[] args)
    {
        HashTable<string, int> ht = new HashTable<string, int>(10);
        ht.Add("one", 1);
        ht.Add("two", 2);
        ht.Add("three", 3);
        ht.Add("four", 4);
        ht.Add("five", 5);
        Console.WriteLine("Printing HashTable:");
        ht.PrintHashTable();
        Console.WriteLine($"ht contains 'six'? - {ht.Contains("six")}");
        Console.WriteLine($"ht contains 'one'? - {ht.Contains("one")}");
        Console.WriteLine($"Removing 'one'\n");
        ht.Remove("one");
        Console.WriteLine("Printing HashTable:");
        ht.PrintHashTable();
        Console.WriteLine($"ht contains 'one'? - {ht.Contains("one")}\n");
        Console.WriteLine($"Get value of 'two': {ht.Get("two")}\n");
        Console.WriteLine($"Get size of HashTable: {ht.Size()}\n");
        Console.WriteLine("Printing HashTable:");
        ht.PrintHashTable();
        Console.WriteLine("Clearing the HashTable...\n");
        ht.Clear();
        Console.WriteLine("Printing HashTable:");
        ht.PrintHashTable();
    }
}
