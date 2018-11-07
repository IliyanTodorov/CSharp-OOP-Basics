namespace WildFarm.Contracts
{
    public interface IAnimal
    {
        //string Name, double Weight, int FoodEaten
        string Name { get; }

        double Weight { get; }

        int FoodEaten { get; }

        string ProduceSound();

        void Eat(IFood food, int quantity);
    }
}