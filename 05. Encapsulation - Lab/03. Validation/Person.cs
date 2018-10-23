using System;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;
    private decimal percentage;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public decimal Salary
    {
        get
        {
            return salary;
        }
        private set
        {
            if (value < 460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva.");
            }

            this.salary = value;
        }
    }

    public string FirstName
    {
        get { return firstName; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return lastName; 
        }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            lastName = value;
        }
    }

    public int Age
    {
        get
        {
            return age;
        }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            age = value;
        }
    }


    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} gets {this.Salary:F2} leva.";
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age > 30)
        {
            this.salary += this.salary * percentage / 100;
        }
        else
        {
            this.salary += this.salary * percentage / 200;
        }
    }
}
