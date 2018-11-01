using BirthdayCelebrations.Contracts;
using FoodShortage.Models;

namespace BorderControl.Models
{
    public class Citizen : Person, IIdentifiable, IBirthable
    {
        private const int increasingNumber = 10;

        public string Id { get; }
        public string Birthdate { get; }

        public Citizen(string name, int age, string id, string birthdate)
            : base(name, age)
        {
            Id = id;
            Birthdate = birthdate;
        }

        public override void BuyFood()
        {
            Food += increasingNumber;
        }
    }
}
