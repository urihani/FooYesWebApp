using System.Data.Entity;
using FooYes.Data.Models;

namespace FooYes.Data.Services
{
    public class RestaurantDataDBContext : DbContext
    {
        public RestaurantDataDBContext()
        : base("RestaurantDataDBContext")
        {
        }

        public DbSet<DishModel> Dishes { get; set; }
        public DbSet<RestaurantModel> Restaurants { get; set; }
    }
}