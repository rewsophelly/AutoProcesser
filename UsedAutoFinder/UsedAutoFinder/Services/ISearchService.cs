using Common.Models;

namespace UsedAutoFinder.Services
{
    public interface ISearchService
    {
        Task<IEnumerable<VehicleListing>> Search(SearchRequest request);
    }
}
