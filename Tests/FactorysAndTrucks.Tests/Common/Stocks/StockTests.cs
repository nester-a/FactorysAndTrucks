using FactorysAndTrucks.Common.Products;
using FactorysAndTrucks.Common.Stocks;
using Xunit;

namespace FactorysAndTrucks.Tests.Common.Stocks
{
    public class StockTests
    {
        [Fact]

        public void TryAddToStockTest()
        {
            var stock = new Stock(1);

            var product1 = new Product("Test1", 1, Interfaces.Product.Props.PackingType.Box);
            var product2 = new Product("Test2", 1, Interfaces.Product.Props.PackingType.Box);

            var res1 = stock.TryAddOnStock(product1);
            var res2 = stock.TryAddOnStock(product2);

            Assert.True(res1);
            Assert.False(res2);
            Assert.Equal(1, stock.FactLoad);
        }
    }
}
