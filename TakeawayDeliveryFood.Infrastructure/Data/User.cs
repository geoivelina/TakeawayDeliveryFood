using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static TakeawayDeliveryFood.Infrastructure.Data.DataConstants.User;
namespace TakeawayDeliveryFood.Infrastructure.Data
{
    public class User :IdentityUser
    {
        [Required]
        [StringLength(FullNameMaxLength)]
        public string FullName { get; set; }

        [Required]
        [StringLength(AddressMaxLength)]
        public string Address { get; set; }
    }
}
