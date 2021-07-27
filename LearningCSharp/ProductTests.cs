using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace LearningCSharp
{
    public class ProductTests
    {
        [Fact]
        public void CreatingAProductRecord()
        {
            var coffee = new Product()
            {
                Id = 32,
                Price = 10.99M,
                Qty = 5
            };

            Assert.Equal(32, coffee.Id);

            var newProduct = DoInventoryAdjustment(coffee, 15);

            Assert.Equal(32, newProduct.Id);
            Assert.Equal(10.99M, newProduct.Price);
            Assert.Equal(15, newProduct.Qty);

            var song = new Song("Pump up the Volume", "M/A/R/S", "Greatest Hits");

            Assert.Equal("Pump up the Volume", song.Title);

        }

        public Product DoInventoryAdjustment(Product p, int newQty)
        {
            //var result = new Product
            //{
            //    Id = p.Id,
            //    Price = p.Price,
            //    Qty = newQty
            //};
            //return result;
            return p with { Qty = newQty };
        }
    }

    public record Product
    {
        public int Id { get; init; }
        public decimal Price { get; init; }

        public int Qty { get; init; }
    }

    public record Song(string Title, string Artist, string Album);
}
