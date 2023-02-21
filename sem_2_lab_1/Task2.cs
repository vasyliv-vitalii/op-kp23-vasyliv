class MyClass
{
    static void Main(string[] args)
    {
        string roadtofile1 = "D:\\123232323\\lab3task1\\text.txt";
        string roadtofile2 = "D:\\123232323\\lab3task1\\text.txt";
        FileStream file1 = new FileStream(roadtofile1, FileMode.Create);
        FileStream file2 = new FileStream(roadtofile2, FileMode.Create);
        Random random = new Random();
        int max = 0;
        int step = 0;
    }
}