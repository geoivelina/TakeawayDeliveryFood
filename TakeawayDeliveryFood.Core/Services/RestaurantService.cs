using Microsoft.EntityFrameworkCore;
using TakeawayDeliveryFood.Core.Contracts;
using TakeawayDeliveryFood.Core.Models.Restaurant;
using TakeawayDeliveryFood.Infrastructure.Data;
using TakeawayDeliveryFood.Infrastructure.Data.Entities;

namespace TakeawayDeliveryFood.Core.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRepository repo;

        public RestaurantService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<RestaurantCuisineTypeModel>> AllCuisineTypes()
        {
            return await repo.AllReadonly<CuisineType>()
                 .OrderBy(c => c.Name)
                 .Select(c => new RestaurantCuisineTypeModel()
                 {
                     Id = c.Id,
                     Name = c.Name,
                 })
                 .ToListAsync();
        }

        public async Task<IEnumerable<RestaurantIndexModel>> AllRestaurants()
        {
            return await repo.AllReadonly<Restaurant>()
                .OrderByDescending(r => r.Id)
                .Select(r => new RestaurantIndexModel()
                {
                    Id = r.Id,
                    CuisineType = r.CuisineType.Name,
                    Name = r.Name,
                    DeliveryCost = r.DeliveryCost,
                    DeliveryTime = r.DeliveryTime,
                    Description = r.Description,
                    MinOrderAmount = r.MinOrderAmount,
                    Rating = r.Rating,
                    RestaurantImage = r.RestaurantImage,
                    WorkingHours = r.WorkingHours
                })
                .ToListAsync();
        }

        public async Task<int> Create(RestaurantModel model)
        {
            var restaurant = new Restaurant()
            {
                Name = model.Name,
                RestaurantImage = model.RestaurantImage,
                WorkingHours = model.WorkingHours,
                Description = model.Description,
                DeliveryCost = model.DeliveryCost,
                DeliveryTime = model.DeliveryTime,
                MinOrderAmount = model.MinOrderAmount,
                CuisineTypeId = model.CuisineTypeId
            };

            await repo.AddAsync(restaurant);
            await repo.SaveChangesAsync();

            return restaurant.Id;
        }

        public async Task<bool> CuisineTypeExist(int cuisineTypeID)
        {
            return await repo.AllReadonly<CuisineType>()
                 .AnyAsync(c => c.Id == cuisineTypeID);
        }
    }
}
