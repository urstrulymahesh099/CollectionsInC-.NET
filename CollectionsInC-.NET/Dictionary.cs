using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsInC_.NET
{
    internal class Dictionary
    {
        public static void Check()
        {
            Dictionary<string, string> Movies = new Dictionary<string, string>();
            Movies.Add("Kannada", "KGF,Kantara,VikranthRonna");
            Movies.Add("Telugu", "Bahubali,RRR,Pushpa");
            Movies.Add("Tamil", "Vikram,PS1,Lovetoday");
            Movies.Add("Hindhi", "RamSetu,Brahmastra,GanguBhai");
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string, string> data in Movies)
            {
                Console.WriteLine($"Key:{data.Key},Value:{data.Value}");
            }
            Console.WriteLine("\nAccessing Dictionary Elements using For Loop");
            for (int i = 0; i < Movies.Count; i++)
            {
                string Key = Movies.Keys.ElementAt(i);
                string Value = Movies[Key];
                Console.WriteLine($"Key: {Key}, Value: {Value}");
            }
            Console.WriteLine("\nChecking the key using the ContainsKey method");
            Console.WriteLine("\nIs Kannada Key Exists : " + Movies.ContainsKey("Kannada"));
            Console.WriteLine("\nIs Tamil Key Exists : " + Movies.ContainsKey("Tamil"));
            Console.WriteLine("\nIs English Key Exists : " + Movies.ContainsKey("English"));
            Console.WriteLine("\n Clear movies from Dictionary Using Clear() method\n");
            {
                Movies.Clear();
                Console.WriteLine($"After clearing Movies : {Movies.Count}");
                foreach (var item in Movies)
                {
                    Console.WriteLine($"Key:{item.Key}::Value:{item.Value}");
                }
            }
        }
          
    }
}
