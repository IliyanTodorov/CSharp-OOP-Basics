namespace DefiningClasses
{
    using System;
    using Employee;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();
            var departmentsSalary = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                FindBiggestSalaryByDepart(departmentsSalary, input);

                Employee employee = GetCurrentEmployee(input);
                employees.Add(employee);
            }

            string highestDepart = departmentsSalary
                .OrderByDescending(x => x.Value)
                .ToArray()[0]
                .Key;

            Console.WriteLine($"Highest Average Salary: {highestDepart}");

            employees = employees
                .Where(x => x.Department == highestDepart)
                .OrderByDescending(x => x.Salary)
                .ToList();

            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }

        }

        private static Employee GetCurrentEmployee(string[] input)
        {
            string name = input[0];
            decimal salary = decimal.Parse(input[1]);
            string position = input[2];
            string depatment = input[3];
            string email;
            int age;

            Employee employee = new Employee(name, salary, position, depatment);

            if (input.Length == 5)
            {
                string str = input[4];
                bool isNumber = int.TryParse(str, out age);

                if (isNumber)
                {
                    employee.Age = age;
                }
                else
                {
                    employee.Email = str;
                }
            }
            else if (input.Length == 6)
            {
                email = input[4];
                age = int.Parse(input[5]);

                employee.Email = email;
                employee.Age = age;
            }

            return employee;
        }

        static void FindBiggestSalaryByDepart(Dictionary<string, decimal> departmentsSalary, string[] input)
        {
            var salary = decimal.Parse(input[1]);
            var department = input[3];

            if (!departmentsSalary.ContainsKey(department))
            {
                departmentsSalary[department] = 0;
            }

            departmentsSalary[department] += salary;
        }
    }
}
