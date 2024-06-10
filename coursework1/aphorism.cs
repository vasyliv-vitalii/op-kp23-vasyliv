using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cursova
{
    class aphorism : abstractclass
    {
        private string author;
        private string source;
        private string topics;
        private string keywords;
        private string aphorisms;
        private string type;

        // поставити path до aphorism.csv
        string path = "";

        public string Type { get => type; }
        public string Author { get => author; }
        public string Aphorisms { get => aphorisms; }
        public string Source { get => source; }
        public string Topics { get => topics; }
        public string Keyword { get => keywords; }
        public List<proverb> ListOfSaying = new List<proverb>();
        public aphorism(string author, string aphorisms, string source, string type, string topics, string keywords)
        {
            this.author = author;
            this.aphorisms = aphorisms;
            this.source = source;
            this.type = type;
            this.topics = topics;
            this.keywords = keywords;
        }

        public override string[] LoadData()
        {
            var sr = new StreamReader(path);
            int lenght = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lenght++;
            }
            sr.Close();
            string[] arrayofaphorisms = new string[lenght];
            StreamReader sr1 = new StreamReader(path);
            for (int i = 0; i < arrayofaphorisms.Length; i++)
            {
                arrayofaphorisms[i] = sr1.ReadLine();
            }
            sr1.Close();
            return arrayofaphorisms;
        }

        public override void ShowList(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        public override string[] SearchbyAuthor(string autor, string[] array)
        {
            List<string> list = new List<string>();
            foreach (var item in array)
            {
                var strings = item.Split('|');
                if (strings[0].ToLower() == autor.ToLower())
                {
                    list.Add(item);
                }
            }
            string[] result = new string[list.Count];
            result = list.ToArray();
            return result;
        }

        public override string[] SearchbySourse(string sources, string[] array)
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

        public override string[] SearchbyType(string type, string[] array)
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

        public override void AddToList(string[] array)
        {
            List<string> list = new List<string>();
            list = LoadData().ToList();
            string path = "D:\\pythonTasks\\cw\\op-kp23-vasyliv\\coursework1\\aphorism.csv";
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

        public override string[] SearchbyTopics(string topics, string[] array)
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

        public override string[] SearchbyKeywords(string keywords, string[] array)
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