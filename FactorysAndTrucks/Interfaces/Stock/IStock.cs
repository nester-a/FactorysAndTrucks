namespace FactorysAndTrucks.Interfaces.Stock
{
    public interface IStock
    {
        int Capacity { get; }
        int FactLoad { get; }

        bool TryAddOnStock(IProduct product);
    }
}
