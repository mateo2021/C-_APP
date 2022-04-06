using OdeToFood.Core;
using System.Collections.Generic;


namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
        Restaurant Update(Restaurant UpdateRestaurant);
        Restaurant Delete(int id);
        int commit();
        Restaurant Add(Restaurant newRestaurant);

    }
}
