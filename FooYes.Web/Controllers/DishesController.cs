using System.Web.Mvc;
using FooYes.Data.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc.Html;
using FooYes.Data.Models;

namespace FooYes.Web.Controllers
{
    public class DishesController : Controller
    {
        readonly IRestaurantData _restaurantData;

        public DishesController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        [HttpGet]
        public ActionResult Index(int id)
        {
            IEnumerable<DishModel> dishes = _restaurantData.GetDishByRestaurantId(id);
            ViewBag.RestaurantName = _restaurantData.GetRestaurantById(id).Name;
            ViewBag.RestaurantId = id;
            ViewBag.Dishes = dishes;
            return View();
        }
        
        [HttpPost]
        public ActionResult DishesByCategory(int id, DishModel.MenuType category)
        {
            RestaurantModel restaurant = _restaurantData.GetRestaurantById(id);
            IEnumerable<DishModel> dishes = _restaurantData.GetDishByRestaurantId(id);
            IEnumerable<DishModel> filteredDishes = dishes.Where(p => p._MenuType == category).ToList();
            if (category == DishModel.MenuType.All)
            {
                filteredDishes = _restaurantData.GetDishByRestaurantId(id);
            }

            ViewBag.RestaurantName = restaurant.Name;
            ViewBag.RestaurantId = id;
            ViewBag.Dishes = filteredDishes;
            return View();
        }
    }
}