using System;
namespace AssignmentThree
{
    public class Restaurant:IComparable<Restaurant>
    {

        public string Name { get; set; }
        public string Location { get; set; }
        public string Style { get; set; }

        public Restaurant()
        {
            Name = "Papeya";
            Location = "Curry Student Center";
            Style = "Hamburger";
        }

        public Restaurant(string name, string location, string style)
        {
            Name = name;
            Location = location;
            Style = style;
        }

        public int CompareTo(Restaurant other)
        {
            return string.Compare(Name, other.Name, StringComparison.Ordinal);

        }

        public override string ToString()
        {
            return $"# {Name} Located at {Location} for {Style}";
        }
    }
}
