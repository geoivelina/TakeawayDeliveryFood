using System.ComponentModel.DataAnnotations;
using static TakeawayDeliveryFood.Infrastructure.Data.DataConstants.Restaurant;

namespace TakeawayDeliveryFood.Core.Models.Restaurant
{
    public class RestaurantModel
    {

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [Display(Name = "Restaurant Image")]
        public string RestaurantImage { get; set; } = null!;


        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(WorkingHoursMaxLength, MinimumLength = WorkingHoursMinLength, ErrorMessage = "Working hours should be in the following format: 13:00 - 23:00")]
        [Display(Name = "Working Hours")]
        public string WorkingHours { get; set; } = null!;

        [Required]
        [StringLength(DeliveryCostMaxLength, MinimumLength = DeliveryCostMinLength)]
        [Display(Name = "Delivery Cost")]
        public string DeliveryCost { get; set; } = null!;

        [Required]
        [StringLength(MinOrderAmountMaxLength, ErrorMessage = "Min order amount shoul be in the following format: Min. 30.99 lv.")]
        [Display(Name = "Minimum order amount")]
        public string MinOrderAmount { get; set; } = null!;

        [Required]
        [Display(Name = "Cuisine Type")]
        public int CuisineTypeId { get; set; }

        [Required]
        [Display(Name = "Delivery Time")]
        [StringLength(DeliveryTimeMaxLength, ErrorMessage = "Delivery time should be in the following format: 20 - 45 min.")]
        public string DeliveryTime { get; set; } = null!;
        public IEnumerable<RestaurantCuisineTypeModel> CuisineTypes { get; set; } = new List<RestaurantCuisineTypeModel>();
    }
}
