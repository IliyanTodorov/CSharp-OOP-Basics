using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main()
        {
            Smartphone smartphone = new Smartphone();

            var numbers = Console.ReadLine()
                .Split();
            var websites = Console.ReadLine()
                .Split();

            foreach (var number in numbers)
            {
                try
                {
                    Console.WriteLine(smartphone.Call(number));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var website in websites)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(website));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
