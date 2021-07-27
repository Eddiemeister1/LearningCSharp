using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace LearningCSharp
{
    public class UsingGenerics
    {
        [Fact]
        public void UsingGenericList()
        {
            var favoriteNumbers = new List<int>(); //Parametric Polymorphism
            favoriteNumbers.Add(20);
            favoriteNumbers.Add(108);
            favoriteNumbers.Add(42);

            //favoriteNumbers.Add("Tacos");

            var sumOfFirstTwo = favoriteNumbers[0] + favoriteNumbers[1];

            Assert.Equal(128, sumOfFirstTwo);
        }

        [Fact]
        public void InitializingAList()
        {
            var favoriteNumbers = new List<int> { 20, 108, 42 };

            var sumOfFirstTwo = favoriteNumbers[0] + favoriteNumbers[1];

            Assert.Equal(128, sumOfFirstTwo);
        }

        [Fact]
        public void EnumeratingAList()
        {
            var favoriteNumbers = new List<int> { 20, 108, 42 };
            int total = 0;
            for (int i = 0; i < favoriteNumbers.Count; i++)
            {
                total += favoriteNumbers[i];
            }
            Assert.Equal(170, total);

            total = 0;
            foreach(int num in favoriteNumbers)
            {
                total += num;
            }

            Assert.Equal(170, total);

            Assert.Equal(170, favoriteNumbers.Sum());

            var doubled = favoriteNumbers.Select(n => n * 2);

            favoriteNumbers[0] = 25;
            Assert.Equal(170 * 2, doubled.Sum());
        }
    }
}
