using Common.Models;

namespace Common.Services
{
    public interface IProviderSearchService
    {
        Task<IEnumerable<VehicleListing>> Search(SearchRequest request);
    }
}
