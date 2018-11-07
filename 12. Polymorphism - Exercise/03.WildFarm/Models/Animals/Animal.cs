using System;
using WildFarm.Contracts;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        private string name;
        private double weight;
        private int foodEaten;

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        } 

        public double Weight
        {
            get { return weight; }
            protected set { weight = value; }
        }

        public int FoodEaten
        {
            get { return foodEaten; }
            protected set { foodEaten = value; }
        }

        public abstract string ProduceSound();

        public virtual void Eat(IFood food, int quantity)
        {
            this.FoodEaten += quantity;
            var increasingNumber = WeightMultiplier.IncreasingNumber(this);
            this.Weight += quantity * increasingNumber;
        }

        protected string WrongFood(IFood food)
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}