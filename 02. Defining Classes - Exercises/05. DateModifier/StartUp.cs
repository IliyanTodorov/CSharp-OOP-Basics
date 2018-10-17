namespace DefiningClasses
{
    using System;
    using DateModifier;

    public class StartUp
    {
        static void Main()
        {
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();

            DateModifier difference = new DateModifier();

            int result = difference.FindDifference(dateOne, dateTwo);

            Console.WriteLine(difference);
        }
    }
}
