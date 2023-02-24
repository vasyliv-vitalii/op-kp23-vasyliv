class MyClass
{
    /*
        Test scenarios:                                      Output:
        Input: John,Rembo,20                                 John Rembo 20                   
        Michel,Gordon,99                                     Toni Crack 30
        Jame,Coock,100                                       Laura Brown 40   
        Toni,Crack,30                                        Sara Black 59
        Danil,Hunter,60                                      Caren Nakamura 52
        Laura,Brown,40                                       Eva Dupont 59
        Sara,Black,59                                        Olivia Gonzalez 44
        Maria,Johnson,64
        Caren,Nakamura,52
        Eva,Dupont,59
        Emma,Müller,70
        Olivia,Gonzalez,44
     */
    static void Main(string[] args)
    {
        string path1 = "D:\\kpi23\\op-kp23-vasyliv\\sem_2_lab_1\\Task4\\File1.csv";
        StreamReader sr = new StreamReader(path1);
        int length = 0;
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            var score = Splits(line, ',');
            if (IntParses(score[2]) < 60)
            {
                length++;
            }
        }
        sr.Close();
        sr = new StreamReader(path1);
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            var score = Splits(line, ',');
            if (IntParses(score[2]) < 60 && length != 0)
            {
                Console.WriteLine(score[0] + " " + score[1] + " " + score[2]);
            }
            else if (length == 0 && IntParses(score[2]) > 60)
            {
                Console.WriteLine("Students with scores lower than 60 - absent");
                break;
            }
        }
        sr.Close();
    }

    static string[] Splits(string text, char symbol)
    {
        string[] splits = new string[3];
        for (int i = 0, j = 0; i < text.Length; i++)
        {
            if (text[i] == symbol)
            {
                j++;
            }
            else
            {
                splits[j] += text[i];
            }
        }
        return splits;
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