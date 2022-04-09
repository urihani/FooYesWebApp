using System;
using System.Collections.Generic;
using System.Web.Mvc;
using FooYes.Data.Models;
using FooYes.Data.Services;

namespace FooYes.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartData _cartData;
        private readonly IRestaurantData _restaurantData;

        public CartController(ICartData cartData, IRestaurantData restaurantData)
        {
            _cartData = cartData;
            _restaurantData = restaurantData;
        }

        [HttpGet]
        public ActionResult Index(int id)
        {
            CartModel model = _cartData.Get(id);
            ViewBag.Cart = model;

            return View();
        }

        [HttpPost]
        public ActionResult Create(int dishId, int? quantity)
        {
            CartModel cart = _cartData.Get(0);
            DishModel dish = _restaurantData.GetDishById(dishId);
            int id = cart.Id;
            if (quantity == null)
            {
                return Redirect(Request.UrlReferrer.ToString());
            }
            else
            {
                _cartData.Add(id, dish, quantity.Value);

                return RedirectToAction("Index", new { Id = id });
            }
        }
        
        [HttpPost]
        public ActionResult Update(int dishId, int quantity)
        {
            CartModel cart = _cartData.Get(0);
            DishModel dish = _restaurantData.GetDishById(dishId);
            int id = cart.Id;
            _cartData.Update(id, dish, quantity);

            return RedirectToAction("Index", new { Id = id });
        }
        
        [HttpPost]
        public ActionResult Delete(int dishId)
        {
            CartModel cart = _cartData.Get(0);
            DishModel dish = _restaurantData.GetDishById(dishId);
            int id = cart.Id;
            _cartData.Delete(id, dish);

            return RedirectToAction("Index", new { Id = id });
        }
    }
}