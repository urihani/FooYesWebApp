using FooYes.Data.Models;

namespace FooYes.Data.Services
{
    public interface ICartData
    {
        CartModel Get(int id);
        void Add(int id, DishModel dish, int quantity);
        void Update(int id, DishModel dish, int quantity);
        void Delete(int id, DishModel dish);
    }
}