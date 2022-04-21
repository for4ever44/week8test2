using System;
using System.Collections.Generic;
using System.Text;
using static week8test.Employee;

namespace week8test
{
    abstract class Agency
    {
        public static List<Employee> Generate()
        {
            List<Employee> employees = new List<Employee>() { 
                new Employee { Name = "Jane", id = 1, gender = Gender.F },
                new Employee { Name = "John", id = 3, gender = Gender.M },
                new Employee { Name="Mary", id = 7, gender = Gender.F },
                new Employee { Name = "Lindsay", id = 5, gender = Gender.X },
                new Employee { Name ="Meilin", id = 2, gender = Gender.F }
            };

            return employees;
        }
    }
}
