using System;
using System.Collections.Generic;
using System.Linq;
using FooYes.Data.Models;

namespace FooYes.Data.Services
{
    public class SqlRestaurantDataProvider : IRestaurantData
    {
        private readonly RestaurantDataDBContext _dbContext;

        public ICollection<DishModel> dishesForRestaurant1 { get; set; }
        public ICollection<DishModel> dishesForRestaurant2 { get; set; }
        public ICollection<DishModel> dishesForRestaurant3 { get; set; }
        public ICollection<DishModel> dishesForRestaurant4 { get; set; }

        private static string lorem =
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";

        public SqlRestaurantDataProvider(RestaurantDataDBContext context)
        {
            _dbContext = context;

            if (!context.Restaurants.Any())
            {
                AddAllRestaurants();
            }
        }

        public IEnumerable<RestaurantModel> GetAllRestaurants()
        {
            return _dbContext.Restaurants.OrderBy(d => d.Rating).ToList();
        }

        public RestaurantModel GetRestaurantById(int id)
        {
            return _dbContext.Restaurants.OrderBy(r => r.Id).ToList()[id];
        }

        public DishModel GetDishById(int id)
        {
            foreach (var restaurant in _dbContext.Restaurants)
            {
                var item = restaurant.Dishes.FirstOrDefault(i => i.Id == id);

                if (item != null)
                {
                    return item;
                }
            }

            return null;
        }

        public List<DishModel> GetDishByRestaurantId(int id)
        {
            return _dbContext.Dishes.OrderBy(d => d.Name).ToList();
        }

        public void AddAllRestaurants()
        {
            dishesForRestaurant1 = new List<DishModel>();
            dishesForRestaurant2 = new List<DishModel>();
            dishesForRestaurant3 = new List<DishModel>();
            dishesForRestaurant4 = new List<DishModel>();

            dishesForRestaurant1.Add(new DishModel(0, 0, lorem, 2.15f, "Orangina", DishModel.MenuType.Beverage,
                "orangina.jpg"));
            dishesForRestaurant1.Add(new DishModel(1, 0, lorem, 2.99f, "Coca", DishModel.MenuType.Beverage,
                "coca-cola.png"));
            dishesForRestaurant1.Add(new DishModel(2, 0, lorem, 3.99f, "Mars", DishModel.MenuType.IceCream,
                "mars-ice-cream.jpg"));
            dishesForRestaurant1.Add(new DishModel(3, 0, lorem, 6.99f, "Viennetta",
                DishModel.MenuType.IceCream, "viennetta.jpg"));
            dishesForRestaurant1.Add(new DishModel(4, 0, lorem, 7.99f, "Lasagnes", DishModel.MenuType.Main,
                "lasagnes.jpg"));
            dishesForRestaurant1.Add(new DishModel(5, 0, lorem, 3.99f, "Raviolis", DishModel.MenuType.Main,
                "raviolis.jpg"));
            dishesForRestaurant1.Add(new DishModel(6, 0, lorem, 4.99f, "Banana Split",
                DishModel.MenuType.Dessert, "banana-split.jpg"));
            dishesForRestaurant1.Add(new DishModel(7, 0, lorem, 7.99f, "Fromage blanc",
                DishModel.MenuType.Dessert, "fromage-blanc.jpg"));
            dishesForRestaurant1.Add(new DishModel(8, 0, lorem, 5.99f, "Crevettes", DishModel.MenuType.SeaFood,
                "crevettes.jpg"));
            dishesForRestaurant1.Add(new DishModel(9, 0, lorem, 8.99f, "Langoustes",
                DishModel.MenuType.SeaFood, "langoustes.jpg"));
            dishesForRestaurant1.Add(new DishModel(10, 0, lorem, 8.99f, "Salade niçoise",
                DishModel.MenuType.Starter, "salade-nice.jpg"));
            dishesForRestaurant1.Add(new DishModel(11, 0, lorem, 8.99f, "Cake aux olives",
                DishModel.MenuType.Starter, "cake-olives.jpg"));

            dishesForRestaurant2.Add(new DishModel(0, 1, lorem, 2.15f, "Orangina", DishModel.MenuType.Beverage,
                "orangina.jpg"));
            dishesForRestaurant2.Add(new DishModel(2, 1, lorem, 3.99f, "Mars", DishModel.MenuType.IceCream,
                "mars-ice-cream.jpg"));
            dishesForRestaurant2.Add(new DishModel(4, 1, lorem, 7.99f, "Lasagnes", DishModel.MenuType.Main,
                "lasagnes.jpg"));
            dishesForRestaurant2.Add(new DishModel(6, 1, lorem, 4.99f, "Banana Split",
                DishModel.MenuType.Dessert, "banana-split.jpg"));
            dishesForRestaurant2.Add(new DishModel(8, 1, lorem, 5.99f, "Crevettes", DishModel.MenuType.SeaFood,
                "crevettes.jpg"));
            dishesForRestaurant2.Add(new DishModel(10, 1, lorem, 8.99f, "Salade niçoise",
                DishModel.MenuType.Starter, "salade-nice.jpg"));

            dishesForRestaurant3.Add(new DishModel(0, 2, lorem, 2.15f, "Orangina", DishModel.MenuType.Beverage,
                "orangina.jpg"));
            dishesForRestaurant3.Add(new DishModel(2, 2, lorem, 3.99f, "Mars", DishModel.MenuType.IceCream,
                "mars-ice-cream.jpg"));
            dishesForRestaurant3.Add(new DishModel(4, 2, lorem, 7.99f, "Lasagnes", DishModel.MenuType.Main,
                "lasagnes.jpg"));
            dishesForRestaurant3.Add(new DishModel(6, 2, lorem, 4.99f, "Banana Split",
                DishModel.MenuType.Dessert, "banana-split.jpg"));
            dishesForRestaurant3.Add(new DishModel(8, 2, lorem, 5.99f, "Crevettes", DishModel.MenuType.SeaFood,
                "crevettes.jpg"));
            dishesForRestaurant3.Add(new DishModel(10, 2, lorem, 8.99f, "Salade niçoise",
                DishModel.MenuType.Starter, "salade-nice.jpg"));

            dishesForRestaurant4.Add(new DishModel(0, 3, lorem, 2.15f, "Orangina", DishModel.MenuType.Beverage,
                "orangina.jpg"));
            dishesForRestaurant4.Add(new DishModel(2, 3, lorem, 3.99f, "Mars", DishModel.MenuType.IceCream,
                "mars-ice-cream.jpg"));
            dishesForRestaurant4.Add(new DishModel(4, 3, lorem, 7.99f, "Lasagnes", DishModel.MenuType.Main,
                "lasagnes.jpg"));
            dishesForRestaurant4.Add(new DishModel(6, 3, lorem, 4.99f, "Banana Split",
                DishModel.MenuType.Dessert, "banana-split.jpg"));
            dishesForRestaurant4.Add(new DishModel(8, 3, lorem, 5.99f, "Crevettes", DishModel.MenuType.SeaFood,
                "crevettes.jpg"));
            dishesForRestaurant4.Add(new DishModel(10, 3, lorem, 8.99f, "Salade niçoise",
                DishModel.MenuType.Starter, "salade-nice.jpg"));

            _dbContext.Restaurants.Add(new RestaurantModel(
                0,
                RestaurantModel.RestaurantType.Italian,
                "italian.jpg",
                "Le Cinecitta",
                "7 Rue Jay, 38000 Grenoble",
                3.0f,
                dishesForRestaurant1));

            _dbContext.Restaurants.Add(
                new RestaurantModel(
                    1,
                    RestaurantModel.RestaurantType.Chinese,
                    "chinese.jpg",
                    "Au Dragon d'Or", "14 Rue Clôt Bey, 38000 Grenoble",
                    4.0f,
                    dishesForRestaurant2));

            _dbContext.Restaurants.Add(
                new RestaurantModel(
                    2,
                    RestaurantModel.RestaurantType.Mexican,
                    "mexican.jpg",
                    "Viva Mexico",
                    "7 Rue Jean Prévost, 38000 Grenoble",
                    9.0f,
                    dishesForRestaurant3));

            _dbContext.Restaurants.Add(
                new RestaurantModel(
                    3,
                    RestaurantModel.RestaurantType.Vegetarian,
                    "vegetarian.jpg",
                    "Katmandou",
                    "4 Rue Condorcet, 38000 Grenoble",
                    6.5f,
                    dishesForRestaurant4));
            _dbContext.SaveChanges();
        }
    }
}