using FactorysAndTrucks.Common.Products;
using FactorysAndTrucks.Interfaces.Factory;

namespace FactorysAndTrucks.Common.Factorys
{
    public class Factory : IFactory
    {
        public string Name { get; }
        public double ManufactureSpeed { get; }
        public IFactoryProduct FactoryProduct { get; }
        public IProduct CreateProduct()
        {
            return new Product(FactoryProduct.FactorysProductName, FactoryProduct.FactorysProductWeight, FactoryProduct.FactorysProductPakingType);
        }
        public Factory(string name, double manufactureSpeed, IFactoryProduct factoryProduct)
        {
            Name = name;
            ManufactureSpeed = manufactureSpeed;
            FactoryProduct = factoryProduct;
        }
    }
}
