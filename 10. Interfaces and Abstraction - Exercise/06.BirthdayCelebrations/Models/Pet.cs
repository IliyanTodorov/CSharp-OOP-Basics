using BirthdayCelebrations.Contracts;

namespace BirthdayCelebrations.Models
{
    public class Pet : IBirthable
    {
        private string name;
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        
        public string Birthdate
        {
            get { return birthdate; }
            private set { birthdate = value; }
        }

    }
}
