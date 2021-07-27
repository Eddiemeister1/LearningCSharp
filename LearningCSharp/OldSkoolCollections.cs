using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class OldSkoolCollections
    {
        // THESE SHOULD NOT BE USED IN CURRENT SOFTWARE
        [Fact]
        public void ListsOfThings()
        {
            var favoriteNumbers = new ArrayList();

            favoriteNumbers.Add(20);
            favoriteNumbers.Add(108);
            favoriteNumbers.Add(42);

            Assert.Equal(20, favoriteNumbers[0]);
            Assert.Equal(42, favoriteNumbers[2]);

            favoriteNumbers[1] = "Tacos";

            var sumOffFirstTwoNumbers = ((int)favoriteNumbers[0]) + ((int)favoriteNumbers[1]);

            Assert.Equal(120, sumOffFirstTwoNumbers);
        }
    }
}
