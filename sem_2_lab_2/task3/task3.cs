using lab2task3;

class MyClass
{
    static void Main(string[] args)
    {
        Vector vec1 = new Vector(1, 2, 3, 0, 5, 6);
        Vector vec2 = new Vector(1, 2, 3, 4, 5, 1);
        Console.WriteLine(vec2 + vec1);
        Console.WriteLine(vec2 * vec1);
        Console.WriteLine(vec1 - vec2);
    }
}