public class Student
{
    private string name;
    private int age;
    private double grade;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public double Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    public Student(string name, int age, double grade)
    {
        this.Name = name;
        this.Age = age;
        this.Grade = grade;
    }

    private string GetCommentary()
    {
        if (this.Grade >= 5.00)
        {
            return " Excellent student.";
        }
        else if (this.Grade < 5.00 && this.Grade >= 3.50)
        {
            return " Average student.";
        }
        else
        {
            return " Programmer.";
        }
    }

    public override string ToString()
    {
        return $"{this.Name} is {this.Age} years old." + GetCommentary();
    }
}
