class Program
{

    static void Main(string[] args)
    {
        var sr = new StreamReader(@"D:\kpi23\op-kp23-vasyliv\sem_2_lab_1\Task4\File1.csv");
       

        var bw = new BinaryWriter(new FileStream("D:\\kpi23\\op-kp23-vasyliv\\sem_2_lab_1\\Task6\\binaryStudents1.csv", FileMode.OpenOrCreate));
       

        var br = new BinaryReader(new FileStream("D:\\kpi23\\op-kp23-vasyliv\\sem_2_lab_1\\Task6\\binaryStudents1.csv", FileMode.Open));
        text = br.ReadString();
      

        string[] arr = Split(text);

      
    }
    static string[] Split(string str)
    {
        string[] res = new string[1];
        int idx = 0;
     
        return res;
    }
    static void Resize<T>(ref T[] arr, int size)
    {
        T[] newarr = new T[size];
        arr = newarr;
    }

    static int IntParses(string numb)
    {
        int res = 0;       
        return res;
    }
}