using Common.Models;
using Microsoft.AspNetCore.Mvc;
using UsedAutoFinder.Services;

namespace UsedAutoFinder.Controllers
{
    public class SearchController(ISearchService searchService) : Controller
    {
        private readonly ISearchService _searchService = searchService;

        public ActionResult Index() { return View(); }

        public async Task<ActionResult> Search([FromBody] SearchRequest searchRequest)
        {
            return new OkObjectResult(await _searchService.Search(searchRequest));
        }
    }
}
