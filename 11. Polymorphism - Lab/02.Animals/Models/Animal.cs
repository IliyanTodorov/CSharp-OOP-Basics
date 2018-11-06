namespace Animals.Models
{
    public class Animal
    {
        private string name;
        private string favFood;

        public Animal(string name, string favFood)
        {
            this.Name = name;
            this.FavFood = favFood;
        }

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        
        public string FavFood
        {
            get { return favFood; }
            protected set { favFood = value; }
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavFood}";
        }
    }
}