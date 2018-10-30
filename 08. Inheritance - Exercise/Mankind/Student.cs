using System;

namespace Mankind
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }
        
        public string FacultyNumber
        {
            get { return facultyNumber; }
            protected set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Faculty number: {FacultyNumber}\n";
        }
    }
}
