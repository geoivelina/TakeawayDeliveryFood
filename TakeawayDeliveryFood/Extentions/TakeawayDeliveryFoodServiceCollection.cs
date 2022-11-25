using TakeawayDeliveryFood.Core.Contracts;
using TakeawayDeliveryFood.Core.Services;
using TakeawayDeliveryFood.Infrastructure.Data;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class TakeawayDeliveryFoodServiceCollection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IRestaurantService, RestaurantService>();

            return services;
        }
    }
}
