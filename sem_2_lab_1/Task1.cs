class MyClass
{
    static void Main(string[] args)
    {
        string roadtofile = "D:\\123232323\\lab3task1\\test.txt";
        FileStream file = new FileStream(roadtofile, FileMode.Create);
        file.Close();
        StreamWriter sw = new StreamWriter(roadtofile);
        sw.WriteLine("Hello word");
        sw.WriteLine("Hello Friends");
        sw.Close();
        StreamReader sr = new StreamReader(roadtofile);
        Console.WriteLine(sr.ReadToEnd());
        sr.Close();
    }
}
