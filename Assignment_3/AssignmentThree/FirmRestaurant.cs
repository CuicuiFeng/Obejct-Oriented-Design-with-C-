using System;
using System.Collections.Generic;

namespace AssignmentThree
{
    public class FirmRestaurant: AbstractFirm
    {

        public FirmRestaurant()
        {
            FirmType = "Restaurant";
        }

        public FirmRestaurant(string firmtype)
        {
            FirmType = firmtype;
        }

        public static void Demo()
        {
            Console.WriteLine("\n\t This is the list of restaurants. ");
            FirmRestaurant firmRestaurant = new FirmRestaurant();

            firmRestaurant.AddRestaurant(new Restaurant("Eastern", "Chinatown", "Chinese Food"));
            firmRestaurant.AddRestaurant(new Restaurant("California Pizza", "Fenway", "Pizza"));
            firmRestaurant.AddRestaurant(new Restaurant("Poke Station", "Symphony", "Japansese"));
            firmRestaurant.AddRestaurant(new Restaurant("Pho", "Huntington", "Thailand"));
            firmRestaurant.AddRestaurant(new Restaurant("Jio Ho", "Malden", "Chinese"));
            firmRestaurant.ShowRestaurantTable();
            firmRestaurant.SortRestaurantTable();
            Console.WriteLine("\n\t This is the result after the sorting.");
            firmRestaurant.ShowRestaurantTable();

            //List<Restaurant> firmRestaurant = new List<Restaurant>
            //{
            //    new Restaurant{ Name = "Eastern", Location = "Chinatown", Style ="Chinese"},
            //    new Restaurant{ Name = "california Pizza", Location = "Fenway", Style = "Pizza"},
            //    new Restaurant{ Name ="Poke Station", Location = "Symphony", Style = "Japansese"},
            //    new Restaurant{ Name = "Pho", Location ="Huntington", Style = "Thailand"},
            //};
            //foreach (Restaurant restaurant in firmRestaurant)
            //{
            //    Console.WriteLine(restaurant);
            //}
            //Console.WriteLine("\n Sort Restaurants By Name");
            //firmRestaurant.SortRestaurant();
            //Console.WriteLine(restaurant);
            }
            
    }
}
