using FactorysAndTrucks.Interfaces.Product.Props;

namespace FactorysAndTrucks.Interfaces.Factory
{
    public interface IFactoryProduct
    {
        public string FactorysProductName { get; }

        public int FactorysProductWeight { get; }

        public PackingType FactorysProductPakingType { get; }
    }
}
