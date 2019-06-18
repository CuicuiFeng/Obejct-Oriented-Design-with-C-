using System;
namespace AssignmentThree
{
    public class FirmSalon: AbstractFirm
    {
        public FirmSalon()
        {
            FirmType = "Salon";
        }

        public FirmSalon(string firmtype)
        {
            FirmType = firmtype;
        }


        public static void Demo()
        {
            Console.WriteLine("\n\t This is the list of salons. ");
            FirmSalon firmSalon = new FirmSalon();
            firmSalon.AddSalon(new Salon("Beauty", "Korean Town", "Hair", 20));
            firmSalon.AddSalon(new Salon("Zoen", "Malden", "Body", 40));
            firmSalon.AddSalon(new Salon("Tony", "Watertown", "Nail", 60));
            firmSalon.AddSalon(new Salon("World", "backbay", "Hair", 30));
            firmSalon.AddSalon(new Salon("Miss.Ann", "downtown", "Body", 80));

            firmSalon.ShowSalonTable();
            firmSalon.SortSalonTable();
            Console.WriteLine("\n\t This is the result after the sorting.");
            firmSalon.ShowSalonTable();

        }

    }
}