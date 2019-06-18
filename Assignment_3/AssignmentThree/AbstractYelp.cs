using System;

namespace AssignmentThree
{
    public abstract class AbstractYelp
    {

        public abstract void AddRestaurant(Restaurant restaurant); //achieve Single Responsibility Principle
        public abstract void AddSalon(Salon salon);
        //public abstract void AddManager(Manager manager);

        public abstract void SortRestaurantTable();      
        public abstract void SortSalonTable();
        //public abstract void SortManager();

        public abstract void ShowRestaurantTable();
        public abstract void ShowSalonTable();
        //public abstract void ShowManager();
    }
}
