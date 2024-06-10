using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursova
{
    internal interface Search
    {
        string[] SearchbyAuthor(string Author, string[] array);
        string[] LoadData();
        void ShowList(string[] array);
        string[] SearchbySourse(string sources, string[] array);
        string[] SearchbyType(string typr, string[] array);
        void AddToList(string[] array);
        string[] SearchbyTopics(string topics, string[] array);
        string[] SearchbyKeywords(string keywords, string[] array);
    }
}
