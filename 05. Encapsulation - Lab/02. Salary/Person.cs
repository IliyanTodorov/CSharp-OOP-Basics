public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;
    private decimal percentage;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public decimal Salary => salary;

    public decimal Percentage => percentage;

    public string FirstName => firstName;

    public string LastName => lastName;

    public int Age => age;

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
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
