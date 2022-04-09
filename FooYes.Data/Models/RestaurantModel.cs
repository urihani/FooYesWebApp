using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FooYes.Data.Models
{
    public class RestaurantModel
    {
        public int Id { get; set; }

        public enum RestaurantType
        {
            Italian,
            Vegetarian,
            Mexican,
            Chinese
        }

        [Display(Name = "Type : ")] public RestaurantType Type { get; set; }

        [Display(Name = "Image : ")] public string ImgPath { get; set; }

        [Display(Name = "Name : ")] public string Name { get; set; }

        [Display(Name = "Address : ")] public string Address { get; set; }

        [Display(Name = "Rating : ")] public float Rating { get; set; }

        [Display(Name = "Restaurants : ")] public IEnumerable<DishModel> Dishes { get; set; }

        public RestaurantModel()
        {
        }

        public RestaurantModel(int id, RestaurantType type, string name, string address, float rating,
            IEnumerable<DishModel> dishes)
        {
            Id = id;
            Type = type;
            Name = name;
            Address = address;
            Rating = rating;
            Dishes = dishes;
        }

        public RestaurantModel(int id, RestaurantType type, string imgPath, string name, string address, float rating,
            IEnumerable<DishModel> dishes)
        {
            Id = id;
            Type = type;
            ImgPath = imgPath;
            Name = name;
            Address = address;
            Rating = rating;
            Dishes = dishes;
        }
    }
}