namespace _03._StudentSystem
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            StudentSystem studentSystem = new StudentSystem();

            string input;
            while ((input = Console.ReadLine()) != "Exit")
            {
                studentSystem.ParseCommand(input);
            }
        }
    }
}
