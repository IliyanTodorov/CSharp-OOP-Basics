using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public string Name
        {
            get { return this.name; }
        }
        public decimal Salary
        {
            get { return this.salary; }
        }
        public string Position
        {
            get { return this.position; }
        }
        public string Department
        {
            get { return this.department; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = "n/a";
            this.age = -1;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Salary:F2} {this.Email} {this.Age}";
        }
    }
}
