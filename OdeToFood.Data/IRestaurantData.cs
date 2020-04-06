using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Pizza Addy", Location="Sarreguemines", Cuisine=CuisineType.Italian },
                new Restaurant { Id = 2, Name = "City Döner", Location="Mannheim", Cuisine=CuisineType.Turkish },
                new Restaurant { Id = 3, Name = "La Tasca", Location="Kingston", Cuisine=CuisineType.Mexican }
            };

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
                   
        }
    }
}
