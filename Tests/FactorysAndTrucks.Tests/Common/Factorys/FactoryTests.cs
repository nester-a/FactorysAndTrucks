using FactorysAndTrucks.Common.Factorys;
using FactorysAndTrucks.Interfaces.Product.Props;
using Xunit;

namespace FactorysAndTrucks.Tests.Common.Factorys
{
    public class FactoryTests
    {
        [Fact]
        public void CreateProductTest()
        {
            var productName = "Test-product";
            var weight = 5;
            var packing = PackingType.NoPack;
            var factoryProduct = new FactoryProduct(productName, weight, packing);
            FactorysAndTrucks.Common.Factorys.Factory factory = new("Test-factory", 1, factoryProduct);

            var product = factory.CreateProduct();
            Assert.NotNull(product);
            Assert.Equal(weight, product.Weight);
            Assert.Equal(packing, product.Packing);
            Assert.Equal(productName, product.Name);
        }
    }
}
