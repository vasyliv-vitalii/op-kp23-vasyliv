using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursova
{
    abstract class abstractclass : Search
    {
        public virtual string[] SearchbyAuthor(string Author, string[] array)
        {
            List<string> list = new List<string>();
            foreach (var item in array)
            {
                var strings = item.Split('|');
                if (strings[0].ToLower() == Author.ToLower())
                {
                    list.Add(item);
                }
            }
            string[] result = new string[list.Count];
            result = list.ToArray();
            return result;
        }
        public virtual string[]  LoadData()
        {
            string path = "D:\\123232323\\cursova\\cursova\\phraseologicalunits.csv";
            var sr = new StreamReader(path);
            int lenght = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lenght++;
            }
            sr.Close();
            string[] arrayofsaying = new string[lenght];
            StreamReader sr1 = new StreamReader(path);
            for (int i = 0; i < arrayofsaying.Length; i++)
            {
                arrayofsaying[i] = sr1.ReadLine();
            }
            sr1.Close();
            return arrayofsaying;
        }
        public virtual void ShowList(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        public virtual string[] SearchbySourse(string sources, string[] array)
        {
            List<string> list = new List<string>();
            foreach (var item in array)
            {
                var strings = item.Split('|');
                if (strings[2].ToLower() == sources.ToLower())
                {
                    list.Add(item);
                }
            }
            string[] answer = list.ToArray();
            return answer;
        }
        public virtual string[] SearchbyType(string type, string[] array)
        {
            List<string> list = new List<string>();
            foreach (var item in array)
            {
                var strings = item.Split('|');
                if (strings[3].ToLower() == type.ToLower())
                {
                    list.Add(item);
                }

            }
            string[] answer = list.ToArray();
            return answer;
        }
        public virtual void AddToList(string[] array)
        {
            List<string> list = new List<string>();
            list = LoadData().ToList();
            string path = "D:\\123232323\\cursova\\cursova\\phraseologicalunits.csv";
            string line = "";
            foreach (var item in array)
            {
                line += item + "|";
            }
            list.Add(line);
            var sw = new StreamWriter(path);
            foreach (var item in list)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }
        public virtual  string[] SearchbyTopics(string topics, string[] array)
        {
            List<string> list = new List<string>();
            foreach (var item in array)
            {
                var strings = item.Split('|');
                var topict = strings[4].Split(',');
                for (int i = 0; i < topict.Length; i++)
                {
                    if (topict[i] == topics)
                    {
                        list.Add(item);
                    }
                }
            }
            string[] answer = list.ToArray();
            return answer;
        }
        public virtual string[] SearchbyKeywords(string keywords, string[] array)
        {
            List<string> list = new List<string>();
            foreach (var item in array)
            {
                var strings = item.Split('|');
                var keywordsfromarray = strings[5].Split(',');
                var keywords1 = keywords.Split(',');
                for (int i = 0; i < keywords1.Length; i++)
                {
                    for (int j = 0; j < keywordsfromarray.Length; j++)
                    {
                        if (keywords1[i] == keywordsfromarray[j])
                        {
                            list.Add(item);
                        }
                    }
                }
            }
            string[] answer = list.ToArray();
            return answer;
        }
    }
}
