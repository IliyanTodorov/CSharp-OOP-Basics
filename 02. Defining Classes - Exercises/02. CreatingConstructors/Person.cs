﻿namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age) : this()
        {
            this.age = age;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        private string name;
        private int age;

        public string Name { get { return name; } set { this.name = value; } }
        public int Age { get { return age; } set { this.age = value;} }
    }
}
