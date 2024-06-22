using Common.Models;
using Common.Services;

namespace UsedAutoFinder.Services
{
    public class SearchService([FromKeyedServices(Constants.Craigslist)] IProviderSearchService craigslistSearchService) : ISearchService
    {
        private readonly IProviderSearchService _craigslistSearchService = craigslistSearchService;

        public async Task<IEnumerable<VehicleListing>> Search(SearchRequest request)
        {
            var craigslistResults = await _craigslistSearchService.Search(request);

            return craigslistResults;
        }
    }
}
