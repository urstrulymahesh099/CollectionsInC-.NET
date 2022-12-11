using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsInC_.NET
{
    internal class ArrayAtSameStatement
    {
        public static void Array()
        {
            //Creating and Initializing an Array
            //Here, the size will be decided based on the number of elements
            int[] Numbers = { 101, 202, 203 };
            //accessing array elements separately
            Console.WriteLine("Accessing the Array Elements separately");
            Console.WriteLine($"Numbers[0] = {Numbers[0]}");
            Console.WriteLine($"Numbers[1] = {Numbers[1]}");
            Console.WriteLine($"Numbers[2] = {Numbers[2]}");
            Console.WriteLine("\nAccessing the Array Elements using ForEach Loop");
            foreach (var data in Numbers)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("\nAccessing the Array Elements using For Loop");
            for(int i=0;i<=Numbers.Length-1;i++)
            {
                Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
            }
           // Console.ReadKey();
        }
    }
}
