using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeawayDeliveryFood.Core.Models.Restaurant;

namespace TakeawayDeliveryFood.Core.Contracts
{
    public interface IRestaurantService
    {
        Task<IEnumerable<RestaurantIndexModel>> AllRestaurants();
        Task<IEnumerable<RestaurantCuisineTypeModel>> AllCuisineTypes();

        Task<bool> CuisineTypeExist(int cuisineTypeID);
        Task<int> Create(RestaurantModel model);
    }
}
