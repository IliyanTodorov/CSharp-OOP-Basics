using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (value.Length < 1)
                {
                    InvalidInput();
                }
                this.name = value;
            }
        }
        public int Age
        {
            get => this.age;
            set
            {
                if (value < 0)
                {
                    InvalidInput();
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get => this.gender;
            set
            {
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    InvalidInput();
                }
                this.gender = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Gender}";
        }

        public virtual string ProduceSound()
        {
            return "";
        }

        private void InvalidInput()
        {
            throw new ArgumentException("Invalid input!");
        }
    }
}
