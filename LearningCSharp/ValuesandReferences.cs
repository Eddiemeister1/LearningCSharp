using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class ValuesandReferences
    {
        [Fact]
        public void SomeExamples()
        {
            // old school
            int age;
            age = 32;
            Assert.Equal(32, age);
            age = 33;
            age += 5; // age = age + 5
            Assert.Equal(38, age);

            Int32 yourAge = 24;
            Assert.Equal(24, yourAge);

            ValuesandReferences me;

            string name = "Bob";
            String yourName = "Sue";

            decimal myPay = 22.53M;

            // 3.0 (2008) they added the "var" keyword for implicitly typed local variables
            var hisName = "Roger";

            //hisName = 1138;
            var yourPay = 18.53M;


        }

        [Fact]
        public void AssignmentWithValueTypes()
        {
            int x = 10;
            int y = x;

            y = 12;

            Assert.Equal(10, x);
        }

        [Fact]
        public void AssignmentWithReferenceTypes()
        {
            Dog x = new Dog();
            x.Name = "Fido";

            Dog y = x;
            y.Name = "Rover";

            Assert.Equal("Rover", x.Name);
        }

        [Fact]
        public void WashingTheDog()
        {
            var d = new Dog() { Name = "Java" }; //That is an object initializer

            var g = new DogGroomer();
            g.WashTheDog(d);

            Assert.NotEqual("Java", d.Name);

        }

        [Fact]
        public void WashingTheInteger()
        {
            var x = 32;

            var g = new DogGroomer();

            g.WashTheNumber(ref x);

            Assert.Equal(64, x);
        }

        public void SwappingSomeNumbers()
        {
            var x = 10;
            var y = 20;

            //Step 2: Magic!
            Swap<int>(ref x, ref y);
            Assert.Equal(20, x);
            Assert.Equal(10, y);

            var x2 = "Joe";
            var y2 = "Sue";

            // ??
            Swap<string>(ref x2, ref y2);

            Assert.Equal("Sue", x2);
            Assert.Equal("Joe", y2);
        }

        public void Swap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        [Fact]
        public void ChangingAString()
        {
            var myName = "jeff";

            var upperName = myName.ToUpper();

            //Assert.Equal("JEFF", myName); //This is going to return false
            Assert.Equal("JEFF", upperName); //This is going to return true
        }

        [Fact]
        public void StringsAreImmutable()
        {
            //immutable means you can't change (mutate) it
            //this is bad don't do this.
            string numbers = "";

            for(int t = 0; t < 1000; t++)
            {
                numbers += t;
            }

            //Assert.Equal("TACOS", numbers);
        }

        [Fact]
        public void StringbuilderForMutableStrings()
        {
            var numbers = new StringBuilder();

            //basic guidance - use a StringBuilder if you are modifying a string more than 3 times
            // or any modifications on a large string (like, bigger than 10k or so)
            for(int t = 0; t < 1000; t++)
            {
                numbers.Append(t);
            }

            //Assert.Equal("TACOS", numbers.ToString());
        }
        
        //overload
        public void Swap(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }


    }

    public class Dog
    {
        public string Name;
    }
}
