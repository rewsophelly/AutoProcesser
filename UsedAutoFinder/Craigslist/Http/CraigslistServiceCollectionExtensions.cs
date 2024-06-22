using Common.Models;
using Common.Services;
using Craigslist.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Craigslist.Http
{
    public static class CraigslistServiceCollectionExtensions
    {
        public static IServiceCollection AddCraigslistServices(this IServiceCollection services)
        {
            // var config = services.AddHttpClient
            services.AddKeyedTransient<IProviderSearchService, CraigslistSearchService>(Constants.Craigslist);

            services.AddHttpClient<CraigslistSearchService>((serviceProvider, client) =>
            {
                var settings = serviceProvider.GetRequiredService<IOptions<CraigslistConfig>>().Value;

                if (settings?.BaseUrl == null)
                    throw new Exception("Craigslist settings not configured");

                client.BaseAddress = new Uri(settings.BaseUrl);
            });

            return services;
        }
    }
}
