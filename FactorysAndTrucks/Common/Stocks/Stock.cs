using FactorysAndTrucks.Interfaces.Stock;

namespace FactorysAndTrucks.Common.Stocks
{
    public class Stock : IStock
    {
        List<IProduct> _stocksProducts;
        public int Capacity { get; }
        public int FactLoad { get => _stocksProducts.Count; }

        public Stock(int capacity)
        {
            Capacity = capacity;
            _stocksProducts = new List<IProduct>();
        }

        public bool TryAddOnStock(IProduct product)
        {
            if(!(FactLoad + 1 <= Capacity)) return false;

            _stocksProducts.Add(product);

            return true;
        }
    }
}
