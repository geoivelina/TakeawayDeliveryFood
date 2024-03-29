﻿using TakeawayDeliveryFood.Infrastructure.Data.Entities;

namespace TakeawayDeliveryFood.Core.Models.Restaurant
{
    public class RestaurantDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rating { get; set; }
        public string RestaurantImage { get; set; } = null!;

        public string Description { get; set; } = null!;
      
        public string WorkingHours { get; set; } = null!;

        public string DeliveryCost { get; set; } = null!;

        public string MinOrderAmount { get; set; } = null!;
      
        public string DeliveryTime { get; set; } = null!;

        public IEnumerable<Dish> Dishes { get; set; } = new List<Dish>();
    }
}
