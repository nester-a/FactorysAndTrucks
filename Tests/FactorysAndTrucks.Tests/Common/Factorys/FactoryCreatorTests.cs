using FactorysAndTrucks.Common.Factorys;
using Xunit;
namespace FactorysAndTrucks.Tests.Common.Factory
{
    public class FactoryCreatorTests
    {
        [Fact]
        public void CreateFactoryTest()
        {
            var creator = new FactoryCreator();

            var factory = creator.CreateFactory();
            Assert.NotNull(factory);
            Assert.NotNull(factory.FactoryProduct);
            Assert.NotEmpty(factory.Name);
            Assert.NotEqual(0, factory.ManufactureSpeed);
        }
    }
}
