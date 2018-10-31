using System;

namespace Ferrari
{
    public class StartUp
    {
        static void Main()
        {
            string driver = Console.ReadLine();
            Ferrari ferrari = new Ferrari(driver);
            Console.WriteLine($"{ferrari.model}/{ferrari.Brake()}/{ferrari.PushGasPedal()}/{ferrari.Driver}");
        }
    }
}
