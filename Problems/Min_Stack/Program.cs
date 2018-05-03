using System;

namespace Min_Stack
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
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            var m1 = minStack.GetMin(); //--> 返回 - 3.
            Console.WriteLine(m1);
            minStack.Pop();
            var t = minStack.Top(); //--> 返回 0.
            Console.WriteLine(t);
            var m2 = minStack.GetMin(); //--> 返回 - 2.
            Console.WriteLine(m2);
        }
    }
}
