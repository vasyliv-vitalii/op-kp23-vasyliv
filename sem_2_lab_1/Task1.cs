class MyClass
{
    static void Main(string[] args)
    {
        string roadtofile = "";
        FileStream file = new FileStream(roadtofile, FileMode.Create);
        StreamWriter sw = new StreamWriter(roadtofile);
        StreamReader sr = new StreamReader(roadtofile);
    }
}
