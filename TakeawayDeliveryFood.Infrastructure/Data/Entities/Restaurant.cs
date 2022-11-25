using System.ComponentModel.DataAnnotations;
using static TakeawayDeliveryFood.Infrastructure.Data.DataConstants.Restaurant;

namespace TakeawayDeliveryFood.Infrastructure.Data.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;


        [Required]
        public string RestaurantImage { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(WorkingHoursMaxLength)]
        public string WorkingHours { get; set; } = null!;

        [Required]
        public int CuisineTypeId { get; set; }
        public CuisineType CuisineType { get; set; } = null!;

        [Required]
        [MaxLength(DeliveryCostMaxLength)]
        public string DeliveryCost { get; set; } = null!;

        [Required]
        [MaxLength(MinOrderAmountMaxLength)]
        public string MinOrderAmount { get; set; } = null!;

        [Required]
        [MaxLength(DeliveryTimeMaxLength)]
        public string DeliveryTime { get; set; } = null!;

        [Required]
        public decimal Rating { get; set; } = 0.0m;

        public IEnumerable<Dish> Dishes { get; set; } = new List<Dish>();

    }
}
