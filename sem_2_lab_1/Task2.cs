class MyClass
{
    static void Main(string[] args)
    {
        string roadtofile1 = "D:\\123232323\\lab3task1\\text.txt";
        string roadtofile2 = "D:\\123232323\\lab3task1\\text.txt";
        FileStream file1 = new FileStream(roadtofile1, FileMode.Create);
        file1.Close();
        FileStream file2 = new FileStream(roadtofile2, FileMode.Create);
        file2.Close();
        Random random = new Random();
        StreamWriter sw = new StreamWriter(roadtofile1);
        int max = 0;
        int step = 0;
        for (int i = 0; i < 15; i++)
        {
            step = random.Next(1, 100);
            if (step > max)
            {
                max = step;
            }
            sw.Write(step + " ");
        }
        sw.Close();
        StreamReader sr = new StreamReader(roadtofile1);
        Console.WriteLine(sr.ReadToEnd());
        sr.Close();
        StreamWriter sw1 = new StreamWriter(roadtofile2);
        sw1.Write(max);
        sw1.Close();
        StreamReader sr1 = new StreamReader(roadtofile2);
        Console.WriteLine(sr1.ReadToEnd() + " - max value");
        sr1.Close();

    }
}