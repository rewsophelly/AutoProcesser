using Common.Models;
using Microsoft.AspNetCore.Mvc;
using UsedAutoFinder.Services;

namespace UsedAutoFinder.Controllers
{
    public class SearchController(ISearchService searchService) : Controller
    {
        private readonly ISearchService _searchService = searchService;

        public ActionResult Index()
        {
            // await Search(new SearchRequest());
            return View(Array.Empty<VehicleListing>());
        }

        public async Task<ActionResult> Search(string searchRequest)
        {

            var vehicles = await _searchService.Search(new SearchRequest());
            return View("Index", vehicles);
        }
    }
}
