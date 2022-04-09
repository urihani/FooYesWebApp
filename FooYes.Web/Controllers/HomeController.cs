using FooYes.Data.Models;
using FooYes.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FooYes.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public ActionResult Index()
        {
            IEnumerable<RestaurantModel> model = _restaurantData.GetAllRestaurants();
            ViewBag.Categories = Enum.GetValues(typeof(RestaurantModel.RestaurantType));
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}