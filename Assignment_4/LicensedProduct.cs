using System;

namespace MidTerm
{
    class LicensedProduct : CustomerOffering
    {
        public LicensedProduct(string csvdata)
        {
            string[] tokens = csvdata.Split(',');
            Id = ParseInt(tokens[0]);
            Price = ParseDouble(tokens[1]);
            Name = tokens[2];
            Description = tokens[3];
        }

        public int ParseInt(string s)
        {
            int n = 0;
            try
            {
                n = Int32.Parse(s);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Can not parse {s} !");
                Console.WriteLine(e);

            }
            return n;
        }

        public double ParseDouble(string s)
        {
            double n = 0;
            try
            {
                n = double.Parse(s);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Can not parse {s} !");
                Console.WriteLine(e);

            }
            return n;
        }

        public override string ToString()
        {
            return $"#Id:{Id} Price:{Price} Name: {Name}  Description: {Description} ";
        }
    }
}
