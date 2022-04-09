using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooYes.Data.Models
{
    public class DishModel
    {
        private sealed class IdEqualityComparer : IEqualityComparer<DishModel>
        {
            public bool Equals(DishModel x, DishModel y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.Id == y.Id;
            }

            public int GetHashCode(DishModel obj)
            {
                return obj.Id;
            }
        }

        public static IEqualityComparer<DishModel> IdComparer { get; } = new IdEqualityComparer();

        public int Id { get; set; }
        [ForeignKey("Restaurant")]
        public virtual int RestaurantId { get; set; }
        public RestaurantModel Restaurant { get; set; }

        public enum MenuType
        {
            [Display(Name = "All")] All,
            [Display(Name = "Starter")] Starter,
            [Display(Name = "Main")] Main,
            [Display(Name = "Dessert")] Dessert,
            [Display(Name = "Beverage")] Beverage,
            [Display(Name = "Sea food")] SeaFood,
            [Display(Name = "Ice cream")] IceCream
        }

        [Display(Name = "Type : ")] public MenuType _MenuType { get; set; }

        [Required(ErrorMessage = "Field Price is Required")]
        [Range(0.0, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        [Display(Name = "Price : ")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Field Name is Required")]
        [StringLength(20, ErrorMessage = "Name Max Length is 20")]
        [Display(Name = "Name : ")]
        public string Name { get; set; }

        [Display(Name = "Image : ")] public string ImgPath { get; set; }

        [Display(Name = "Description : ")] public string Description { get; set; }

        public DishModel()
        {
        }

        public DishModel(int id, int restaurantId, string description, float price, string name, MenuType _menuType)
        {
            Id = id;
            RestaurantId = restaurantId;
            Price = price;
            Name = name;
            _MenuType = _menuType;
            Description = description;
            Restaurant = new RestaurantModel();
        }

        public DishModel(int id, int restaurantId, string description, float price, string name, MenuType _menuType, string imgPath)
        {
            Id = id;
            RestaurantId= restaurantId;
            Price = price;
            Name = name;
            _MenuType = _menuType;
            ImgPath = imgPath;
            Description = description;
        }
    }
}