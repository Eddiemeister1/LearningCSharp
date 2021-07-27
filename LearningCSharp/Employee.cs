using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{

    public class EmployeeTests
    {

        [Fact]
        public void CreatingAnEmployee()
        {
            var joe = new Employee("Joseph Schmidt", 520000);
            //joe.Name = "Joseph Schmidt";
            //joe.Salary = 520000;
            Assert.Equal("Joseph Schmidt", joe.Name);
            Assert.Equal(520000, joe.Salary);
            Assert.Equal("unknown", joe.Email);

            var mary = new Employee("Mary Proto", 830000, "mary@aol.com");
            Assert.Equal("mary@aol.com", mary.Email);

        }

    }
    public class Employee
    {
        //Having multiple methods with the same name is called overloading
        public Employee(string name, decimal salary):this(name, salary, "unknown")
        {
        }
        public Employee(string name, decimal salary, string email)
        {
            Name = name;
            Salary = salary;
            Email = email;
        }
        public string Name { get; private set; }
        public decimal Salary { get; private set; }

        public string Email { get; private set; }
    }
}
