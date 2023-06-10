using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursova
{
    class afterlogin
    {
        public void AfterLogin(User user)
        {
            sayings Admin = new sayings("1", "1", "1", "1", "1", "1");
            proverb Adm = new proverb("1", "1", "1", "1", "1", "1");
            aphorism Adm1 = new aphorism("1", "1", "1", "1", "1", "1");
            pun adnm2 = new pun("1", "1", "1", "1", "1", "1");
            sarcasm adm12 = new sarcasm("1", "1", "1", "1", "1", "1");
            phraseologicalunits admins1 = new phraseologicalunits("1", "1", "1", "1", "1", "1");
            catchphrases a1 = new catchphrases("1", "1", "1", "1", "1", "1");
            Console.WriteLine("Hello," + user.Name);
            Console.WriteLine("It is your account.");
            Console.WriteLine("Write /command - to check the list of commands.");
            while (true)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "/command":
                        {
                            Console.Clear();
                            break;
                        }
                    case "/addtofav":
                        {
                            Console.Clear();
                            string[] array = Admin.LoadData();
                            string[] array2 = Adm.LoadData();
                            string[] array3 = Adm1.LoadData();
                            string[] array4 = adnm2.LoadData();
                            string[] array5 = adm12.LoadData();
                            string[] array6 = admins1.LoadData();
                            string[] array7 = a1.LoadData();
                            List<string> list = new List<string>();
                            list = array.ToList();
                            foreach (var item in array7)
                            {
                                list.Add(item);
                            }
                            foreach (var item in array6)
                            {
                                list.Add(item);
                            }
                            foreach (var item in array5)
                            {
                                list.Add(item);
                            }
                            foreach (var item in array2)
                            {
                                list.Add(item);
                            }
                            foreach (var item in array3)
                            {
                                list.Add(item);
                            }
                            foreach (var item in array4)
                            {
                                list.Add(item);
                            }
                            int counter1 = 1;
                            Console.WriteLine("List of proverbs:");
                            foreach (var item in list)
                            {
                                Console.WriteLine(counter1 + " " + item);
                                counter1++;
                            }
                            Console.WriteLine("Write number and it  add to favourite.");
                            int numb = Convert.ToInt32(Console.ReadLine());
                            numb = numb > 0 ? numb : 0;
                            int counter = 1;
                            if (numb == 0)
                            {
                                Console.Clear();
                                break;
                            }
                            foreach (var item in list)
                            {

                                if (counter == numb)
                                {
                                    user.favourites.Add(item);
                                }
                                counter++;
                            }
                            Console.Clear();
                            break;
                        }
                    case "/removefromfav":
                        {
                            Console.Clear();
                            string[] array = user.favourites.ToArray(); ;
                            ListOffavourites(user);
                            Console.WriteLine("write numbre");
                            int numb = Convert.ToInt32(Console.ReadLine());
                            int counter = 0;
                            foreach (var item in array)
                            {

                                if (counter == numb - 1)
                                {
                                    user.favourites.RemoveAt(counter);
                                }
                                counter++;
                            }
                            Console.Clear();
                            break;
                        }
                    case "/listoffav":
                        {
                            Console.Clear();
                            if (user.favourites.Count !=0)
                            {
                                ListOffavourites(user);
                            }
                            else
                            {
                                Console.WriteLine("List is empty");
                            }
                            Console.WriteLine("----press enter to continue----");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "/settings":
                        {
                            Console.Clear();
                            Settings.ChangeSattings(user);
                            Console.Clear();
                            break;
                        }
                    case "/searchbyau":
                        {
                            Console.Clear();
                            Console.WriteLine("write lastname of author");
                            string author = Console.ReadLine();
                            string[] array = Admin.LoadData();
                            string[] answer = Admin.SearchbyAuthor(author, array);
                            string[] array2 = Adm.LoadData();
                            string[] answer2 = Adm.SearchbyAuthor(author, array2);
                            string[] array3 = Adm1.LoadData();
                            string[] answer3 = Adm1.SearchbyAuthor(author, array3);
                            string[] array4 = adm12.LoadData();
                            string[] array5 = adnm2.LoadData();
                            string[] answer4 = adm12.SearchbyAuthor(author, array4);
                            string[] answer5 = adnm2.SearchbyAuthor(author, array5);
                            string[] array6 = admins1.LoadData();
                            string[] answer6 = admins1.SearchbyAuthor(author,array6);
                            string[] array7 = a1.LoadData();
                            string[] answer7 = a1.SearchbyAuthor(author, array7);
                            Console.WriteLine("Search options found");
                            foreach (var item in answer7) Console.WriteLine(item);
                            foreach (var item in answer6) Console.WriteLine(item);
                            foreach (var item in answer4) Console.WriteLine(item);
                            foreach (var item in answer5) Console.WriteLine(item);
                            foreach (var item in answer3) Console.WriteLine(item);
                            foreach (var item in answer) Console.WriteLine(item);
                            foreach (var item in answer2) Console.WriteLine(item);
                            Console.WriteLine("press enter to contine");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "/searchbytype":
                        {
                            Console.Clear();
                            Console.WriteLine("write type");
                            string type = Console.ReadLine();
                            string[] array = Admin.LoadData();
                            string[] answer = Admin.SearchbyType(type, array);
                            string[] array2 = Adm.LoadData();
                            string[] answer2 = Adm.SearchbyType(type, array2);
                            string[] array3 = Adm1.LoadData();
                            string[] array4 = adm12.LoadData();
                            string[] array5 = adnm2.LoadData();
                            string[] answer3 = Adm1.SearchbyType(type, array3);
                            string[] answer4 = adm12.SearchbyType(type, array4);
                            string[] answer5 = adnm2.SearchbyType(type, array5);
                            string[] array6 = admins1.LoadData();
                            string[] answer6 = admins1.SearchbyType(type,array6);
                            string[] array7 = a1.LoadData();
                            string[] answer7 = a1.SearchbyType(type, array7);
                            Console.WriteLine("Search options found");
                            foreach (var item in answer7) Console.WriteLine(item);
                            foreach (var item in answer6) Console.WriteLine(item);
                            foreach (var item in answer4) Console.WriteLine(item);
                            foreach (var item in answer5) Console.WriteLine(item);
                            foreach (var item in answer3) Console.WriteLine(item);
                            foreach (var item in answer) Console.WriteLine(item);
                            foreach (var item in answer2) Console.WriteLine(item);
                            Console.WriteLine("press enter to contine");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "/searchbytopic":
                        {
                            Console.Clear();
                            Console.WriteLine("write topisc");
                            string topic = Console.ReadLine();
                            string[] array = Admin.LoadData();
                            string[] answer = Admin.SearchbyTopics(topic, array);
                            string[] array2 = Adm.LoadData();
                            string[] answer2 = Adm.SearchbyTopics(topic, array2);
                            string[] array3 = Adm1.LoadData();
                            string[] answer3 = Adm1.SearchbyTopics(topic, array3);
                            string[] array4 = adm12.LoadData();
                            string[] array5 = adnm2.LoadData();
                            string[] answer4 = adm12.SearchbyTopics(topic, array4);
                            string[] answer5 = adnm2.SearchbyTopics(topic, array5);
                            string[] array6 = admins1.LoadData();
                            string[] answer6 = admins1.SearchbyTopics(topic, array6);
                            string[] array7 = a1.LoadData();
                            string[] answer7 = a1.SearchbyTopics(topic, array7);
                            Console.WriteLine("Search options found");
                            foreach (var item in answer7) Console.WriteLine(item);
                            foreach (var item in answer6) Console.WriteLine(item);
                            foreach (var item in answer4) Console.WriteLine(item);
                            foreach (var item in answer5) Console.WriteLine(item);
                            foreach (var item in answer3) Console.WriteLine(item);
                            foreach (var item in answer) Console.WriteLine(item);
                            foreach (var item in answer2) Console.WriteLine(item);
                            Console.WriteLine("press enter to contine");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "/searchbykeywords":
                        {
                            Console.Clear();
                            Console.WriteLine("Write keywords");
                            string keywords = Console.ReadLine();
                            string[] array = Admin.LoadData();
                            string[] answer = Admin.SearchbyKeywords(keywords, array);
                            string[] array2 = Adm.LoadData();
                            string[] answer2 = Adm.SearchbyKeywords(keywords, array2);
                            string[] array3 = Adm1.LoadData();
                            string[] answer3 = Adm1.SearchbyKeywords(keywords, array3);
                            string[] array4 = adm12.LoadData();
                            string[] array5 = adnm2.LoadData();
                            string[] answer4 = adm12.SearchbyKeywords(keywords, array4);
                            string[] answer5 = adnm2.SearchbyKeywords(keywords, array5);
                            string[] array6 = admins1.LoadData();
                            string[] answer6 = admins1.SearchbyKeywords(keywords, array6);
                            string[] array7 = a1.LoadData();
                            string[] answer7 = a1.SearchbyKeywords(keywords, array7);
                            Console.WriteLine("Search options found");
                            foreach (var item in answer7) Console.WriteLine(item);
                            foreach (var item in answer6) Console.WriteLine(item);
                            foreach (var item in answer4) Console.WriteLine(item);
                            foreach (var item in answer5) Console.WriteLine(item);
                            foreach (var item in answer3) Console.WriteLine(item);
                            foreach (var item in answer) Console.WriteLine(item);
                            foreach (var item in answer2) Console.WriteLine(item);
                            Console.WriteLine("press enter to contine");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "/addtolist":
                        {
                            Console.Clear();
                            Console.WriteLine("1)Write author's lastname; 2)Write your ; 3)Write sourses; 4) Write type; 5) write topics; 6)write keywords");
                            string name = Console.ReadLine();
                            string sentes = Console.ReadLine();
                            string source = Console.ReadLine();
                            string type = Console.ReadLine();
                            string topics = Console.ReadLine();
                            string keywords = Console.ReadLine();
                            string[] array = { name, source, sentes, type, topics, keywords };
                            if (type == "saying")
                            {
                                Admin.AddToList(array);
                            }
                            else if (type == "proverb")
                            {
                                Adm.AddToList(array);
                            }
                            else if (type == "sarcasm")
                            {
                                adm12.AddToList(array);
                            }
                            else if (type == "pun")
                            {
                                adnm2.AddToList(array);
                            }
                            else if (type == "aphorism")
                            {
                                Adm1.AddToList(array);
                            }
                            else
                            {
                                Console.WriteLine("Write coreect type!!!");
                            }
                            Console.WriteLine("press enter to contine");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "/searchbysource":
                        {
                            Console.WriteLine("Write source");
                            string source = Console.ReadLine();
                            string[] array = Admin.LoadData();
                            string[] answer = Admin.SearchbySourse(source, array);
                            string[] array2 = Adm.LoadData();
                            string[] answer2 = Adm.SearchbySourse(source, array2);
                            string[] array3 = Adm1.LoadData();
                            string[] answer3 = Adm1.SearchbySourse(source, array3);
                            string[] array4 = adm12.LoadData();
                            string[] array5 = adnm2.LoadData();
                            string[] answer4 = adm12.SearchbySourse(source, array4);
                            string[] answer5 = adnm2.SearchbySourse(source, array5);
                            string[] array6 = admins1.LoadData();
                            string[] answer6 = admins1.SearchbySourse(source, array6);
                            string[] array7 = a1.LoadData();
                            string[] answer7 = a1.SearchbySourse(source, array7);
                            Console.WriteLine("Search options found");
                            foreach (var item in answer7) Console.WriteLine(item);
                            foreach (var item in answer6) Console.WriteLine(item);
                            foreach (var item in answer4) Console.WriteLine(item);
                            foreach (var item in answer5) Console.WriteLine(item);
                            foreach (var item in answer3) Console.WriteLine(item);
                            foreach (var item in answer) Console.WriteLine(item);
                            foreach (var item in answer2) Console.WriteLine(item);
                            Console.WriteLine("press enter to contine");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                    case "/showlist":
                        {
                            Console.Clear();
                            string[] array = Admin.LoadData();
                            string[] array2 = Adm.LoadData();
                            string[] array3 = Adm1.LoadData();
                            string[] array4 = adnm2.LoadData();
                            string[] array5 = adm12.LoadData();
                            List<string> list = new List<string>();
                            list = array.ToList();
                            foreach (var item in array5)
                            {
                                list.Add(item);
                            }
                            foreach (var item in array2)
                            {
                                list.Add(item);
                            }
                            foreach (var item in array3)
                            {
                                list.Add(item);
                            }
                            foreach (var item in array4)
                            {
                                list.Add(item);
                            }
                            int counter1 = 1;
                            Console.WriteLine("List of proverbs:");
                            foreach (var item in list)
                            {
                                Console.WriteLine(counter1 + " " + item);
                                counter1++;
                            }
                            Console.WriteLine("press enter to contine");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "/selectedaphorisms":
                        {
                            Console.Clear();
                            SelecrtedAphorism(user);
                            Console.WriteLine("----press enter to continue----");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "/showinfo":
                        {
                            Console.Clear();
                            Console.WriteLine("Info about my account:");
                            ShowInfo(user);
                            Console.WriteLine("press enter to contine");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "/logout":
                        {
                            Console.Clear();
                            return;
                        }
                    default:
                        Console.Clear();
                        Console.WriteLine("write correct command");
                        Thread.Sleep(2500);
                        Console.Clear();
                        break;
                }
                ListOfCommand();
            }
        }

        public void ListOffavourites(User user)
        {
            foreach (var item in user.favourites)
            {
                Console.WriteLine(item);
            }
        }
        public void SelecrtedAphorism(User user)
        {
            foreach (var item in user.favourites)
            {
                var words = item.Split('|');
                if (words[3].ToLower()=="aphorism")
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void ListOfCommand()
        {
            Console.WriteLine("if you want to check command list -/command");
            Console.WriteLine("If you want to check information about account -/showinfo");
            Console.WriteLine("If you want to change accoun's information -/settings");
            Console.WriteLine("If you want to check all proverbs -/showlist");
            Console.WriteLine("If you want to  add to favourite - /addtofav");
            Console.WriteLine("If you want to check list of ofavourite -/listoffav");
            Console.WriteLine("If you want to remove from favourite -/removefromfav");
            Console.WriteLine("if you want to check selected aphorisms for printing -/selectedaphorisms");
            Console.WriteLine("If you want to add something -/addtolist");
            Console.WriteLine("if you want to search something by author - /searchbyau");
            Console.WriteLine("If you want to search something by type - /searchbytype");
            Console.WriteLine("If you want to search something by keywords -/searchbykeywords");
            Console.WriteLine("If you want to search something by source -/searchbysource");
            Console.WriteLine("If you want to search something by topic -/searchbytopic");
            Console.WriteLine("If you want to log out -/logout");
        }

        public void ShowInfo(User user)
        {
            Console.WriteLine("1)Name: " + user.Name + " 2)Email: " + user.Email + " 3)Password:" + user.Password);
        }
    }
}
