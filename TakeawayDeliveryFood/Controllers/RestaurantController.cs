using TakeawayDeliveryFood.Core.Models.Restaurant;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TakeawayDeliveryFood.Core.Contracts;

namespace TakeawayDeliveryFood.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }

        public async Task<IActionResult> All()
        {
            var model = new RestaurantIndexModel();
            return View(model);

        }

        public async Task<IActionResult> Details(int id)
        {
            var model = new RestaurantDetailsViewModel();
            return View(model);
        }
        public async Task<IActionResult> Add()
        {
            //CHECK IF USER IS IN ROLE ADMIN OR MOVE IN AREA
            var model = new RestaurantModel()
            {
                CuisineTypes = await restaurantService.AllCuisineTypes()
            };

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Add(RestaurantModel model)
        {
            //CHECK IF USER IS IN ROLE ADMIN OR MOVE IN AREA

            if ((await restaurantService.CuisineTypeExist(model.CuisineTypeId)) == false)
            {
                ModelState.AddModelError(nameof(model.CuisineTypeId), "Cuisine type does not exist");
            }

            if (!ModelState.IsValid)
            {
                model.CuisineTypes = await restaurantService.AllCuisineTypes();
                return View(model);
            }

            int id = await restaurantService.Create(model);

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            //CHECK IF USER IS IN ROLE ADMIN OR MOVE IN AREA
            var model = new RestaurantModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, RestaurantModel model)
        {
            return RedirectToAction(nameof(Details), new { id });
        }



        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            //CHECK IF USER IS IN ROLE ADMIN OR MOVE IN AREA
            return RedirectToAction(nameof(All));
        }
    }
}
