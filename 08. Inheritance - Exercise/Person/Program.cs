using System;

namespace Person
{
    class Program
    {
        static void Main()
        {
            string childName = Console.ReadLine();
            int childAge = int.Parse(Console.ReadLine());

            try
            {
                Child child = new Child(childName, childAge);
                Console.WriteLine(child.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
