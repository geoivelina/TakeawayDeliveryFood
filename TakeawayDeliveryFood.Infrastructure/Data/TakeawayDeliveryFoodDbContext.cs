using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TakeawayDeliveryFood.Infrastructure.Data.Configuration;

namespace TakeawayDeliveryFood.Infrastructure.Data
{
    public class TakeawayDeliveryFoodDbContext : IdentityDbContext<User>
    {
        public TakeawayDeliveryFoodDbContext(DbContextOptions<TakeawayDeliveryFoodDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           // builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RestaurantConfiguration());
            builder.ApplyConfiguration(new CuisineTypeConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<CuisineType> CuisineTypes { get; set; }
       // public DbSet<User> Users { get; set; }
    }
}