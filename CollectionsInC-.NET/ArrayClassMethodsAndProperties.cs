using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsInC_.NET
{
    internal class ArrayClassMethodsAndProperties
    {
        public static void Name()
        {
            string[] Names = { "Mahesh", "Niranjan", "Marthish", "Prabhas", "AlluArjun" };
            Console.WriteLine("Accessing the Array Elements Before Initialization");
            Console.WriteLine($"Names[]={Names}");
            Console.WriteLine("Accessing the Array Elements Before Initialization using For Loop");
            for (int i = 0; i <= Names.Length-1; i++)
            {
                Console.WriteLine($"Names[{i}]={Names[i]}");
            }
            Console.WriteLine("Accessing the Array Elements Before Initialization using Foreach Loop");
            foreach (var data in Names)
            {
                Console.WriteLine(data +" ");
            }
            Console.WriteLine("Sorting the Array Elements by using the Sort method of Array Class");
            Array.Sort(Names);
            foreach (var data in Names)
            {
                Console.WriteLine(data + " ");
            }
            Console.WriteLine("Reversing the array elements by using the Reverse method of Array Class");
            Array.Reverse(Names);
            foreach (var data in Names)
            {
                Console.WriteLine(data + " ");
            }
            Console.WriteLine("For Arrycopy we need to create another new Array: ");
            string[] NewNames = new string[10];
            Array.Copy(Names, NewNames, 4);
            foreach (var data in Names)
            {
                Console.WriteLine(data + " ");
            }
            Console.WriteLine($"\nNew Array Length using Length Property :{NewNames.Length}");
            Console.WriteLine($"\nOld Array Length using Length Property :{Names.Length}");
        }
    }
}
