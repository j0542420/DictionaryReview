using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryReview
{
    internal class Program
    {
        static Dictionary<string, int> ages = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            ages.Add("John", 25);
            ages.Add("Jane", 30);
            ages.Add("Bob", 35);

            PrintDict();

            ages = Remove("Jane");

            PrintDict();

            Console.ReadLine();
        }

        static void Add(string aName, int anAge)
        {
            ages.Add(aName, anAge);
        }
        static Dictionary<string, int> Remove(string aName)
        {
            var newDict = new Dictionary<string, int>();
            foreach (var a in ages)
            {
                if (a.Key != aName) 
                {
                    newDict.Add(a.Key, a.Value);
                }
            }
            return newDict;
        }
        static void PrintDict()
        {
            foreach (var a in ages)
            {
                Console.WriteLine($"{a.Key} is {a.Value} years old.");
            }
        }
    }
}
