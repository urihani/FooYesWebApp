using System.Collections.Generic;
using System.Linq;
using FooYes.Data.Models;

namespace FooYes.Data.Services
{
    public class CartDataProvider : ICartData
    {
        private List<CartModel> _carts { get; set; }

        public CartDataProvider()
        {
            _carts = new List<CartModel>();
            _carts.Add(new CartModel(0));
        }

        public CartModel Get(int id)
        {
            return _carts.FirstOrDefault(i => i.Id == id);
        }

        // TODO CreateCart method based on the user who created it

        public void Add(int id, DishModel dish, int quantity)
        {
            CartModel cart = _carts.FirstOrDefault(i => i.Id == id);
            if (cart != null && cart.OrderLines.ContainsKey(dish))
            {
                cart.OrderLines[dish] += quantity;
                cart.SetTotal();
            }
            else if (cart == null || !cart.OrderLines.ContainsKey(dish))
            {
                cart.OrderLines.Add(dish, quantity);
                cart.SetTotal();
            }
        }

        public void Update(int id, DishModel dish, int quantity)
        {
            CartModel cart = _carts.FirstOrDefault(i => i.Id == id);
            cart.OrderLines[dish] = quantity;
            cart.SetTotal();
        }

        public void Delete(int id, DishModel dish)
        {
            CartModel cart = _carts.FirstOrDefault(i => i.Id == id);
            cart.OrderLines.Remove(dish);
            cart.SetTotal();
        }
    }
}