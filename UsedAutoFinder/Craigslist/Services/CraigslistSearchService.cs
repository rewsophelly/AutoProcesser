﻿using Common.Models;
using Common.Services;

namespace Craigslist.Services
{
    public class CraigslistSearchService(IHttpClientFactory factory) : IProviderSearchService
    {
        private readonly IHttpClientFactory _httpClientFactory = factory;

        public async Task<IEnumerable<VehicleListing>> Search(SearchRequest request)
        {
            var client = _httpClientFactory.CreateClient(Constants.Craigslist);

            await Task.CompletedTask;

            return
            [
                new VehicleListing
                {
                    Make = "Hyundai",
                    Model = "Elantra",
                    Year = 2005,
                    Price = 5000
                },
                new VehicleListing
                {
                    Make = "Dodge",
                    Model = "Durango",
                    Year = 2006,
                    Price = 600
                }
            ];
        }
    }
}
