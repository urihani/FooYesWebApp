using System.Collections.Generic;
using System.Linq;

namespace FooYes.Data.Models
{
    public class CartModel
    {
        public int Id { get; set; }

        public Dictionary<DishModel, float> TotalByDish { get; set; }

        public float Total { get; set; }
        public Dictionary<DishModel, int> OrderLines { get; set; }

        public CartModel()
        {
        }

        public CartModel(int id)
        {
            Id = id;
            OrderLines = new Dictionary<DishModel, int>(DishModel.IdComparer);
            TotalByDish = new Dictionary<DishModel, float>(DishModel.IdComparer);
        }

        public void SetTotal()
        {
            Total = 0f;
            foreach (var orderLine in OrderLines)
            {
                float subTotal = orderLine.Key.Price * orderLine.Value;
                Total += subTotal;
            }
        }
    }
}