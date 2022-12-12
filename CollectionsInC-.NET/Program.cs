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
                Console.WriteLine("Click the below options -\n1.ArrayAtSameStatement\n2.ArrayInitializingSeparately\n3.ArrayClassMethodsAndProperties\n4.Dictionary");
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
                    case 3:
                        Console.WriteLine("Understand Array Class Methods and Properties in C#");
                        ArrayClassMethodsAndProperties.Name();
                        break;
                    case 4:
                        Console.WriteLine("Understand How to Create a Dictionary<TKey, TValue> Collection and Add Elements in C#:");
                        Dictionary.Check();
                        break;
                        default:
                        Console.WriteLine("Please select error-free option\nTry again ...........");
                        break;
                }
            }
             
            } 
        }
    }
