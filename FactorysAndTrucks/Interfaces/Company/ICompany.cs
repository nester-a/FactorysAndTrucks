using FactorysAndTrucks.Interfaces.Factory;
using FactorysAndTrucks.Interfaces.Manager;
using FactorysAndTrucks.Interfaces.Stock;

namespace FactorysAndTrucks.Interfaces.Company
{
    public interface ICompany
    {
        IManager Manager { get; set; }
        IStock Stock { get; set; }
        IFactory Factory { get; set; }
    }
}
