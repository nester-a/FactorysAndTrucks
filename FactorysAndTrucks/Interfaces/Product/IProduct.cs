using FactorysAndTrucks.Interfaces.Product.Props;

namespace FactorysAndTrucks
{
    public interface IProduct
    {
        string Name { get; }
        int Weight { get; }
        PackingType Packing { get; }
    }
}
