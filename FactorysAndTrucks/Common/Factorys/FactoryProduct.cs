using FactorysAndTrucks.Interfaces.Factory;
using FactorysAndTrucks.Interfaces.Product.Props;

namespace FactorysAndTrucks.Common.Factorys
{
    public class FactoryProduct : IFactoryProduct
    {
        public string FactorysProductName { get; }

        public int FactorysProductWeight { get; }

        public PackingType FactorysProductPakingType { get; }

        public FactoryProduct(string name, int weight, PackingType packingType)
        {
            FactorysProductName = name;
            FactorysProductWeight = weight;
            FactorysProductPakingType = packingType;
        }
    }
}
