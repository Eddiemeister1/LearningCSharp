using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class CustomerTests
    {
        [Fact]
        public void CreatingAnInstanceOfAClass()
        {
            var bob = new Customer();
            bob.Name = "Robert Smith";

            var sue = new Customer();
            sue.Name = "Sue Jones";

            Assert.Equal("Robert Smith", bob.Name);
            Assert.Equal("Sue Jones", sue.Name);
            Assert.Equal(5000M, sue.AvailableCredit);

            var myBirthday = new DateTime(1969, 4, 20, 11, 59, 00); //value type

            var today = DateTime.Now;
        }

        [Fact]
        public void ObjectInitializers()
        {
            var bob = new Customer()
            {
                Name = "Bob Smith",
                Manager = "Jill Jones",
                EmailAddress = "bob@aol.com"
            };

            Assert.Equal("Bob Smith", bob.Name);
            Assert.Equal("Jill Jones", bob.Manager);
            Assert.Equal(5000M, bob.AvailableCredit);

            bob.IncreaseCreditLimit(42);
            Assert.Equal(5042, bob.AvailableCredit);
        }
    }

    public class Customer
    {
        private string _name; // "backing field"
        private decimal _availableCredit = 5000;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public decimal AvailableCredit { get; private set; } = 5000M;

        public string EmailAddress { get; set; } //Auto Property

        public string Manager { get; set; }
        public string GetInfo()
        {
            return $"Customer {_name} has an available credit of {AvailableCredit:c} and can be reached at {EmailAddress}";
        }

        public void IncreaseCreditLimit(decimal amountToAdd)
        {
            // there are business rules.
            AvailableCredit += amountToAdd;
        }
    }
}
