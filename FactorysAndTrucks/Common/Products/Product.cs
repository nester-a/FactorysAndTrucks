using FactorysAndTrucks.Interfaces.Product.Props;

namespace FactorysAndTrucks.Common.Products
{
    public class Product : IProduct
    {
        public string Name { get; }
        public int Weight { get; }
        public PackingType Packing { get; }

        public Product(string name, int weight, PackingType packing)
        {
            Name = name;
            Weight = weight;
            Packing = packing;
        }
    }
}
