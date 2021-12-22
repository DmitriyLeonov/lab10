using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Program
    {
        private static void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Добавлен новый элемент!");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Элемент удален!");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Software<string> word = new Software<string>() {
                Version = "2019",
                LicenseType = "MIT",
                LastUpdate = DateTime.Now.AddDays(-50)
            };
            Software<string> excel = new Software<string>()
            {
                Version = "2015",
                LicenseType = "Apache",
                LastUpdate = DateTime.Now.AddDays(-20)
            };
            Software<string> powerpoint = new Software<string>()
            {
                Version = "2021",
                LicenseType = "MIT",
                LastUpdate = DateTime.Now.AddDays(-5)
            };
            List<Software<string>> microsoft = new List<Software<string>>();
            microsoft.Add(word);
            microsoft.Add(excel);
            microsoft.Add(powerpoint);
            microsoft.Remove(excel);
            Software<string> soft = microsoft.Find(item => item.Version == "2021");
            soft.Print();
            foreach(Software<string> item in microsoft)
            {
                Console.WriteLine(item.Version);
            }

            SortedList<int, string> keyValuePairs = new SortedList<int, string>();
            keyValuePairs.Add(3, "Камино");
            keyValuePairs.Add(1, "Татуин");
            keyValuePairs.Add(2, "Корусант");
            keyValuePairs.Add(0, "Набу");
            for (int i = 0; i < keyValuePairs.Count(); i++)
            {
                Console.WriteLine(keyValuePairs[i]);
            }
            int n = 2;
            for (int i = 0; i < n; i++)
            {
                keyValuePairs.Remove(i);
            }
            keyValuePairs.Add(0, "Экзегол");
            keyValuePairs.Add(1, "Альдераан");
            Queue<string> planets = new Queue<string>();
            for (int i = 0; i < keyValuePairs.Count(); i++)
            {
                planets.Enqueue(keyValuePairs[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < planets.Count; i++)
            {
                Console.WriteLine(planets.ElementAt(i));
            }
            for (int i = 0; i < planets.Count; i++)
            {
                if (planets.ElementAt(i).Equals("Камино"))
                {
                    Console.WriteLine("\n" + planets.ElementAt(i));
                    break;
                }
            }

            ObservableCollection<Software<string>> softwares = new ObservableCollection<Software<string>>();
            softwares.CollectionChanged += CollectionChanged;
            softwares.Add(word);
            softwares.Add(excel);
            softwares.Add(powerpoint);
            softwares.Remove(powerpoint);
            Console.Read();
        }
    }
}
