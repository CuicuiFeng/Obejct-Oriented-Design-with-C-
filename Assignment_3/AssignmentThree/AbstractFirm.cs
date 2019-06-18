using System;
using System.Collections.Generic;

namespace AssignmentThree
{
    public class AbstractFirm: AbstractYelp
    {
        public string FirmType { get; set; }
        private List<Restaurant> RestaurantTable = null;
        private List<Salon> SalonTable = null;

        public AbstractFirm()
        {
            Init("default");
        }

        public AbstractFirm(string FirmType)
        {
            Init(FirmType);
        }

        private void Init(string firmType)
        {
            FirmType = firmType;
            RestaurantTable = new List<Restaurant>();
            SalonTable = new List<Salon>();
        }

        public override void AddRestaurant(Restaurant restaurant)
        {
            RestaurantTable.Add(restaurant);
        }

        public override void SortRestaurantTable()  //achieve Single Responsibility Principle, sort the table of restaurant
        {
            RestaurantTable.Sort();
        }

        public override void ShowRestaurantTable()  //achieve Single Responsibility Principle, show the result of the restaurant
        {
            Console.WriteLine($"There are {RestaurantTable.Count} restaurants in {FirmType}");
            foreach (Restaurant restaurant in RestaurantTable)
            {
                Console.WriteLine(restaurant);
            }
        }

        public override void AddSalon(Salon salon)
        {
            SalonTable.Add(salon);
        }

        public override void SortSalonTable()
        {
            SalonTable.Sort();
        }

        public override void ShowSalonTable()
        {
            Console.WriteLine($"There are {SalonTable.Count} restaurants in {FirmType}");
            foreach (Salon salon in SalonTable)
            {
                Console.WriteLine(salon);
            }
        }
    }



}
