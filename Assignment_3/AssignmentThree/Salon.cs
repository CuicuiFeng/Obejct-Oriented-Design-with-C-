using System;
namespace AssignmentThree
{
    public class Salon: IComparable<Salon>
    {

        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        public Salon()
        {
            Name = "Lily";
            Location = "Fenway";
            Type = "Face";
            Price = 50;
        }

        public Salon(string name, string location, string type, int price)
        {
            Name = name;
            Location = location;
            Type = type;
            Price = price;
        }

        public int CompareTo(Salon other)
        {
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"# {Type} {Name} Located at {Location} for {Price}/one person.";
        }
    }
}
