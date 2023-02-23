class Class
{
    /*Test  test scenarios
     input:Road, ride, air ,Ambulance, track, Tell, Fire, Check, Mouse, trash, Crash, car, tiger, Our, check.
     output:air, Ambulance, car, Check, check, Crash, Fire, Mouse, Our, ride, Road, Tell, tiger, track, trash.
    */
    class MyClass
    {
        static void Main(string[] args)
        {
            string path1 = "D:\\123232323\\Lab3Task3\\Lab3Task3\\TextFile1.txt";
            string path2 = "D:\\123232323\\Lab3Task3\\Lab3Task3\\TextFile2.txt";
            StreamReader sr = new StreamReader(path1);
            int length = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                length++;
            }
            sr.Close();
            string[] arrayofwords = new string[length];
            StreamReader sr1 = new StreamReader(path1);
            for (int i = 0; i < arrayofwords.Length; i++)
            {
                arrayofwords[i] = sr1.ReadLine();
            }
            sr1.Close();
            ShellSort(arrayofwords);
            StreamWriter sw1 = new StreamWriter(path2);
            foreach (var item in arrayofwords)
            {
                sw1.WriteLine(item);
            }
            sw1.Close();
            StreamReader sr2 = new StreamReader(path2);
            Console.WriteLine(sr2.ReadToEnd());

        }

        static string ToLowers(string s)
        {
            string answer = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < 90 && s[i] > 64)
                {
                    char step = Convert.ToChar(s[i] + 32);
                    answer += step.ToString();
                }
                else
                {
                    answer += s[i].ToString();
                }
            }
            return answer;
        }


        static string[] ShellSort(string[] array)
        {

            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && needToReOrder(array[j - d], array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }
                d = d / 2;
            }

            return array;
        }


        static void Swap(ref string a, ref string b)
        {
            string t = a;
            a = b;
            b = t;
        }

        static bool needToReOrder(string w1, string w2)
        {
            w1 = ToLowers(w1);
            w2 = ToLowers(w2);
            for (int i = 0; i < (w1.Length > w2.Length ? w2.Length : w1.Length); i++)
                if (w1[i] > w2[i]) return true;
                else if (w1[i] < w2[i]) return false;
            return true;
        }
    }
}