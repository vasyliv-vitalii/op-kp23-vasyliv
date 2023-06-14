class Program
{

    static void Main(string[] args)
    {
        var sr = new StreamReader(@"D:\kpi23\op-kp23-vasyliv\sem_2_lab_1\Task4\File1.csv");
        string text = sr.ReadToEnd();
        sr.Close();

        var bw = new BinaryWriter(new FileStream("D:\\kpi23\\op-kp23-vasyliv\\sem_2_lab_1\\Task6\\binaryStudents1.csv", FileMode.OpenOrCreate));
        bw.Write(text);
        bw.Close();

        var br = new BinaryReader(new FileStream("D:\\kpi23\\op-kp23-vasyliv\\sem_2_lab_1\\Task6\\binaryStudents1.csv", FileMode.Open));
        text = br.ReadString();
        br.Close();

        string[] arr = Split(text);

        bw = new BinaryWriter(new FileStream("D:\\kpi23\\op-kp23-vasyliv\\sem_2_lab_1\\Task6\\binaryStudents2.csv", FileMode.Create));
        for (int i = 2; i < arr.Length; i += 3)
        {
            if (arr[i] != null && IntParses(arr[i]) >= 95)
            {
                bw.Write(arr[i - 2] + ",");
                bw.Write(arr[i - 1] + ",");
                bw.Write(arr[i]);
                bw.Write("\n");
            }
        }
        bw.Close();
    }
    static string[] Split(string str)
    {
        string[] res = new string[1];
        int idx = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '\r')
                continue;
            else if (str[i] == '\n')
                idx++;
            else if (str[i] != ',')
                res[idx] += str[i];
            else
            {
                idx++;
                if (idx >= res.Length)
                {
                    Resize(ref res, res.Length * 2);
                }
            }
        }
        return res;
    }
    static void Resize<T>(ref T[] arr, int size)
    {
        T[] newarr = new T[size];
        for (int i = 0; i < arr.Length && i < size; i++)
        {
            newarr[i] = arr[i];
        }
        arr = newarr;
    }

    static int IntParses(string numb)
    {
        int res = 0;
        res = numb[0] - 48;
        for (int i = 1; i < numb.Length; i++)
        {
            res *= 10;
            res += numb[i] - 48;
        }
        return res;
    }
}