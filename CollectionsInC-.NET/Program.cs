using System;
namespace CollectionsInC_.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Collections Of Elements in C#.NET");
                Console.WriteLine("Click the below options -\n1.ArrayAtSameStatement\n2.ArrayInitializingSeparately");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option) {
                    case 1:
                        Console.WriteLine("Creating and Initializing an Array at the Same Statement//int[] Numbers = { 101, 202, 303 };//");
                        ArrayAtSameStatement.Array();
                        break;
                    case 2:
                        Console.WriteLine("Creating and Initializing an Array Separately//int[] Numbers = new int[8];//");
                        ArrayInitializingSeparately.Array1();
                        break;
                }
             
            } 
        }
    }
}