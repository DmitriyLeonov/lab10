using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Program
    {
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

        }
    }
}
