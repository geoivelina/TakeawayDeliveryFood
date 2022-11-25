using System.ComponentModel.DataAnnotations;
using static TakeawayDeliveryFood.Infrastructure.Data.DataConstants.CuisineType;

namespace TakeawayDeliveryFood.Infrastructure.Data
{
    public class CuisineType
    {
        public CuisineType()
        {
            this.Restaurants = new List<Restaurant>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; }

        public IEnumerable<Restaurant> Restaurants { get; set; } = null!;
    }
}
