using FactorysAndTrucks.Interfaces.Product.Props;

namespace FactorysAndTrucks.Interfaces.Factory
{
    public interface IFactory
    {
        string Name { get; }
        IFactoryProduct FactoryProduct { get; }
        double ManufactureSpeed { get;}
        IProduct CreateProduct();
    }
}
