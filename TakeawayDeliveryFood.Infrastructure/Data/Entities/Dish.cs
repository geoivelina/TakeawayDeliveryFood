using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static TakeawayDeliveryFood.Infrastructure.Data.DataConstants.Dish;

namespace TakeawayDeliveryFood.Infrastructure.Data.Entities
{
    public class Dish
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [Precision(18, 2)]
        public decimal Price { get; set; }

    }
}
