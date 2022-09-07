using FactorysAndTrucks.Interfaces.Factory;
using FactorysAndTrucks.Interfaces.Product.Props;

namespace FactorysAndTrucks.Common.Factorys
{
    public class FactoryCreator : IFactoryCreator
    {
        static int FactorysCount = 0;
        static double Speed = 1.0;
        public IFactory CreateFactory()
        {
            FactorysCount++;
            var product = GetFactoryProduct();
            var factory = new Factory($"Factory-{FactorysCount}", Speed, product);
            Speed += 0.1;

            return factory;
        }

        private IFactoryProduct GetFactoryProduct()
        {
            Random random = new Random();
            var weight = random.Next(5, 10);
            var packing = random.Next(0, 3);

            return new FactoryProduct($"Factory-{FactorysCount} product", weight, (PackingType)packing);
        }
    }
}
