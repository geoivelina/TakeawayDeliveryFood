using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TakeawayDeliveryFood.Infrastructure.Data.Entities;

namespace TakeawayDeliveryFood.Infrastructure.Data.Configuration
{
    internal class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData(CreateRestaurants());
        }

        private List<Restaurant> CreateRestaurants()
        {
            var restaurants = new List<Restaurant>();

            var restaurant = new Restaurant()
            {
                Id = 1,
                CuisineTypeId = 8,
                Name = "Genaro`s pizza",
                Description = "Authentic Italian pizza",
                WorkingHours = "12:00 - 22:00",
                DeliveryCost = "Free",
                DeliveryTime = "20 - 50 min.",
                MinOrderAmount = "Min. 10.00 lv.",
                RestaurantImage = "https://tse1.mm.bing.net/th?id=OIP.VIHoNlxPTkXfW2i6DgfIbwHaF7&pid=Api",
            };
            restaurants.Add(restaurant);

            restaurant = new Restaurant()
            {
                Id = 2,
                CuisineTypeId = 1,
                Name = "Taj Mahal",
                Description = "Authentic Indian pizza",
                WorkingHours = "11:00 - 23:00",
                DeliveryCost = "Free from 30.00 lv.",
                DeliveryTime = "30 - 50 min.",
                MinOrderAmount = "Min. 20.00 lv.",
                RestaurantImage = "https://tse2.mm.bing.net/th?id=OIP.8gNduGMsG-TnwPqLDlRQVQHaE8&pid=Api"
            };
            restaurants.Add(restaurant);

            restaurant = new Restaurant()
            {
                Id = 3,
                CuisineTypeId = 2,
                Name = "Burgers & Fries",
                Description = "Best American style burgers",
                WorkingHours = "11:00 - 23:00",
                DeliveryCost = "Free from 20.00 lv.",
                DeliveryTime = "20 - 50 min.",
                MinOrderAmount = "Min. 20.00 lv.",
                RestaurantImage = "https://tse1.mm.bing.net/th?id=OIP.W0r1nOj-EPrXoziOqjjFPAHaE8&pid=Api"
            };
            restaurants.Add(restaurant);
            restaurant = new Restaurant()
            {
                Id = 4,
                CuisineTypeId = 11,
                Name = "El Gatto",
                Description = "Cosy Mexican restaurant in the heart of the big city",
                WorkingHours = "11:00 - 22:00",
                DeliveryCost = "2.99 lv.",
                DeliveryTime = "20 - 50 min.",
                MinOrderAmount = "Min. 20.00 lv.",
                RestaurantImage = "https://tse4.mm.bing.net/th?id=OIP.Q74hg6Rl1KPSs-0sUXcXugHaE8&pid=Api"
            };
            restaurants.Add(restaurant);

            restaurant = new Restaurant()
            {
                Id = 5,
                CuisineTypeId = 3,
                Name = "Kioto sushi",
                Description = "Authentic sushi prepared from our sushi master",
                WorkingHours = "11:00 - 24:00",
                DeliveryCost = "2.99 lv.",
                DeliveryTime = "30 - 60 min.",
                MinOrderAmount = "Min. 20.00 lv.",
                RestaurantImage = "https://tse3.mm.bing.net/th?id=OIP.2oT2R6wz3DbEm0NIePcJzwHaE_&pid=Api"
            };
            restaurants.Add(restaurant);


            restaurant = new Restaurant()
            {
                Id = 6,
                CuisineTypeId = 5,
                Name = "Golden dragon",
                Description = "Authentic Chinese dishes",
                WorkingHours = "12:00 - 22:00",
                DeliveryCost = "5.99 lv.",
                DeliveryTime = "30 - 60 min.",
                MinOrderAmount = "Min. 10.00 lv.",
                RestaurantImage = "https://tse2.mm.bing.net/th?id=OIP.GvVXxZP0xh8i9a_1XFmTyAHaE8&pid=Api"
            };
            restaurants.Add(restaurant);

            return restaurants;
        }
    }
}
