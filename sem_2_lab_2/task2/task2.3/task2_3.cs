using lab2task2._3;

class MyClass
{
    static void Main(string[] args)
    {
        Vessle sub = new SailingVessle();
        Submarine s1 = new Submarine();
        s1.PrepareToMove();
        sub.PrepareToMove();

    }
}