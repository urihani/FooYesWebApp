using System.Collections.Generic;
using System.Web.Mvc;
using FooYes.Data.Models;
using FooYes.Data.Services;

namespace FooYes.Web.Controllers
{
    public class DishController : Controller
    {
        private readonly IRestaurantData _restaurantData;

        public DishController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        [HttpGet]
        public ActionResult Index(int id)
        {
            DishModel model = _restaurantData.GetDishById(id);
            ViewBag.Dish = model;
            return View();
        }
    }
}