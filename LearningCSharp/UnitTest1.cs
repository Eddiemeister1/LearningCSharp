using System;
using Xunit;

namespace LearningCSharp
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Given (Arrange)
            int a = 10, b = 20, answer;

            //When (Act)
            answer = a + b;

            //Then (Assert)
            Assert.Equal(30, answer);
        }

        [Fact]
        public void CanCountTheLettersInAString()
        {
            var name = "Peter";

            Assert.Equal(5, name.Length);
        }
        
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(10,3,13)]
        [InlineData(18,2,20)]
        [InlineData(8,8,16)]
        public void CanAddTwoNumbers(int a, int b, int expected)
        {

            var answer = a + b;
            Assert.Equal(expected, answer);

        }
    }
}
