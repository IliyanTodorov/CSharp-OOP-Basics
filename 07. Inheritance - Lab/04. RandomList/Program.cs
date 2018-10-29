using System;

namespace _04._RandomList
{
    class Program
    {
        static void Main()
        {
            var list = new RandomList();

            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list.Add("Four");
            list.Add("Five");
            list.Add("Six");
            list.Add("Seven");
            list.Add("Eight");
            list.Add("Nine");
            list.Add("Ten");

            while (list.Count > 0)
            {
                Console.WriteLine(list.GetRandomElement());
            }
        }
    }
}
