using FooYes.Data.Models;
using System.Collections.Generic;

namespace FooYes.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<RestaurantModel> GetAllRestaurants();
        RestaurantModel GetRestaurantById(int id);
        DishModel GetDishById(int id);
        List<DishModel> GetDishByRestaurantId(int id);
    }
}