using FactorysAndTrucks.Interfaces.Company;

namespace FactorysAndTrucks.Interfaces.Manager
{
    public interface IManager
    {
        ICompany Company { get; set; }
    }
}
