using System;

namespace Insert_Delete_GetRandom_O1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadKey(true);
        }

        static void Test()
        {
            RandomizedSet set = new RandomizedSet();
            Console.WriteLine(set.Insert(3));
            Console.WriteLine(set.Insert(-2));
            Console.WriteLine(set.Remove(2));
            Console.WriteLine(set.Insert(1));
            Console.WriteLine(set.Insert(-3));
            Console.WriteLine(set.Insert(-2));
            Console.WriteLine(set.Remove(-2));
            Console.WriteLine(set.Remove(3));
            Console.WriteLine(set.Insert(-1));
            Console.WriteLine(set.Remove(-3));
            Console.WriteLine(set.Insert(1));
            Console.WriteLine(set.Insert(-2));
            Console.WriteLine(set.Insert(-2));
            Console.WriteLine(set.Insert(-2));
            Console.WriteLine(set.Insert(1));
            Console.WriteLine(set.GetRandom());
            Console.WriteLine(set.Insert(-2));
            Console.WriteLine(set.Remove(0));
            Console.WriteLine(set.Insert(-3));
            Console.WriteLine(set.Insert(1));

        }
    }
}
