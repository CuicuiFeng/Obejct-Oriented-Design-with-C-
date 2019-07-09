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

        //public Product(string csvdata)
        //{
        //    string[] tokens = csvdata.Split(',');
        //    Id = ParseInt(tokens[0]);
        //    Price = ParseDouble(tokens[1]);
        //    Name = tokens[2];
        //    Description = tokens[3];
        //}

        //public int ParseInt(string s)
        //{
        //    int n = 0;
        //    try
        //    {
        //        n = Int16.Parse(s);
        //    }
        //    catch
        //    {
        //        Console.WriteLine($"Can not parse {s} !");
        //    }
        //    return n;
        //}

        //public double ParseDouble(string s)
        //{
        //    double n = 0;
        //    try
        //    {
        //        n = double.Parse(s);
        //    }
        //    catch
        //    {
        //        Console.WriteLine($"Can not parse {s} !");
        //    }
        //    return n;
        //}

        public int CompareTo(Product other)
        {
            return Price.CompareTo(other.Price);
        }

        //public static int CompareById(Product p1, Product p2)
        //{
        //    return p1.Id.CompareTo(p2.Id);
        //}

        //public static int CompareByPrice(Product p1, Product p2)
        //{
        //    return p1.Price.CompareTo(p2.Price);
        //}

        //public static int CompareByName(Product p1, Product p2)
        //{
        //    return string.Compare(p1.Name, p2.Name);
        //}

        //public static int CompareByDescription(Product p1, Product p2)
        //{
        //    return string.Compare(p1.Description, p2.Description);
        //}

        public static Comparison<Product> CompareById = delegate (Product p1, Product p2)
        {
            return p1.Id.CompareTo(p2.Id);
        };

        public static Comparison<Product> CompareByName = delegate (Product p1, Product p2)
        {
            return string.Compare(p1.Name, p2.Name);
        };

        public static Comparison<Product> CompareByPrice = delegate (Product p1, Product p2)
        {
            return p1.Price.CompareTo(p2.Price);
        };

        public static Comparison<Product> CompareByDescription = delegate (Product p1, Product p2)
        {
            return string.Compare(p1.Description, p2.Description);
        };

        public override string ToString()
        {
            return $"# {Id} :  {Name}, Price : {Price}, Description : {Description}";
        }
    }
}
