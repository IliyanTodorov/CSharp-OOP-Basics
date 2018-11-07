using WildFarm.Contracts;

namespace WildFarm.Models
{
    public abstract class Bird : Animal, IBird
    {
        private double wingSize;

        public Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize
        {
            get { return wingSize; }
            protected set { wingSize = value; }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}