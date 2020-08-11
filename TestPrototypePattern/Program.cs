using System;
using TestPrototypePattern.Models;

namespace TestPrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WolfKindAnimals wolf = new WolfKindAnimals(4, 7);
            WolfKindAnimals wolf2 = (WolfKindAnimals)wolf.CopyThisObject();

            Console.WriteLine(wolf.Voice());
            Console.WriteLine("Count of legth wolf1: " + wolf.CountLegth);
            Console.WriteLine("Count of legth wolf2: " + wolf2.CountLegth);
            wolf.CountLegth = 5;
            Console.WriteLine("Count of legth wolf1: " + wolf.CountLegth);            
            Console.WriteLine("Count of legth wolf1: " + wolf2.CountLegth);

            Console.ReadKey();
        }
    }
}
