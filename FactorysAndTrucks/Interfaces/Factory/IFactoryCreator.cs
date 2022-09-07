using FactorysAndTrucks.Interfaces.Factory;

namespace FactorysAndTrucks
{
    public interface IFactoryCreator
    {
        IFactory CreateFactory();
    }
}
