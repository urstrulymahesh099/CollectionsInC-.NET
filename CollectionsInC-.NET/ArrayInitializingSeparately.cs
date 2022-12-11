using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsInC_.NET
{
    internal class ArrayInitializingSeparately
    {

       public static void Array1()
        {
            //Creating an Integer Array with size 3
            int[] Numbers = new int[10];
            Numbers[9] = 400;
            Numbers[7] = 500;
            Numbers[6] = 600;
            //Accessing the Array Elements Before Initialization
            Console.WriteLine("Accessing the Array Elements");
            for (int i = 0; i <= Numbers.Length - 1; i++)
            {
                Console.WriteLine($"Numbers[{i}]={Numbers[i]}");
            }
            Numbers[0] = 10;
            Numbers[1] = 20;
            Numbers[2] = 30;
            //Accessing the Array Elements After Initialization
            Console.WriteLine("\nAccessing the Array Elements After Initialization in foreach loop");
            foreach (var data in Numbers)
            {
                Console.WriteLine(data);
            }

            //Console.ReadKey();
        }
    }
}