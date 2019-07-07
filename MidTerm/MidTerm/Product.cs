using System;
using System.Collections;
using System.Collections.Generic;

namespace MidTerm
{
    public class Product : IComparable<Product>
    {

        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Product(int id, double price, string name, string description)
        {
            Id = id;
            Price = price;
            Name = name;
            Description = description;
        }


        int IComparable<Product>.CompareTo(Product other)
        {
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }

        //public static int SortById(Product p1, Product p2)
        //{
        //    return p1.Id.CompareTo(p2.Id);
        //}

        //public static int SortByPrice(Product p1, Product p2)
        //{
        //    return p1.Id.CompareTo(p2.Price);
        //}

        //public static int SortByDescription(Product p1, Product p2)
        //{
        //    return string.Compare(p1.Description, p2.Description, StringComparison.Ordinal);
        //}

        public override string ToString()
        {
            return $"# {Id} :  {Name}, Price : {Price}, Description : {Description}";
        }
    }
}
