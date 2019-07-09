using System;
namespace MidTerm
{
    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public double Wage { get; set; }

        public Employee(string csvdata)
        {
            string[] tokens = csvdata.Split(',');
            Id = ParseInt(tokens[0]);
            FirstName = tokens[1];
            LastName = tokens[2];
            Age = ParseInt(tokens[3]);
            EmployeeId = ParseInt(tokens[4]);
            Wage = ParseDouble(tokens[5]);
        }

        public int ParseInt(string s)
        {
            int n = 0;
            try
            {
                n = Int16.Parse(s);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Can not parse {e} !");
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
            catch(Exception e)
            {
                Console.WriteLine($"Can not parse {e} !");
            }
            return n;
        }


        public override string ToString()
        {
            return $"# {Id} : {FirstName} {LastName}, age : {Age}, wage : {Wage}";
        }
    }
}
