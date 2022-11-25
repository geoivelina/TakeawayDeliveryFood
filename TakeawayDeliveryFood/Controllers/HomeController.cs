using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TakeawayDeliveryFood.Core.Contracts;
using TakeawayDeliveryFood.Models;

namespace TakeawayDeliveryFood.Controllers
{
    public class HomeController : Controller
    {
       private readonly IRestaurantService restaurantService;

        public HomeController(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}