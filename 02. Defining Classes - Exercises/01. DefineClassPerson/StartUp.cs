namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person pesho = new Person {Name = "Pesho", Age = 20};

            Person gosho = new Person();

            gosho.Name = "Gosho";
            gosho.Age = 18;
        }
    }
}
