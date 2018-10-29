using System;

namespace _05._StackOfStrings
{
    class Program
    {
        static void Main()
        {
            var stack = new StringStack();

            stack.Push("element1");
            stack.Push("element2");
            stack.Push("element3");
            stack.Push("element4");
            stack.Push("element5");
            stack.Push("element6");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Peek());

        }
    }
}
