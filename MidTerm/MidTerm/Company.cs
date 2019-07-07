using System;
using System.Collections.Generic;

namespace MidTerm
{
    public class Company : AbstractBusiness
    {
        public string Name { get; set; }
        private List<Employee> employees = null;
        private List<Product> products = null;

        public Company()
        {
            Init("default");
        }

        public Company(string name)
        {
            Init(name);
        }

        private void Init(string name)
        {
            Name = name;
            employees = new List<Employee>();
            products = new List<Product>();
        }

        public override void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public override void SortEmployee()
        {
            employees.Sort();
        }

        public override void EmployeeInfo()
        {
            Console.WriteLine($"There are {employees.Count} employees in {Name}:");
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }

        //public override void AddClient(AbstractPerson e)
        //{
        //    throw new NotImplementedException();
        //}

        //public override void SortClient()
        //{
        //    throw new NotImplementedException();
        //}

        //public override string ClientInfo()
        //{
        //    throw new NotImplementedException();
        //}

        public override void AddProduct(Product product)
        {
            products.Add(product);
        }

        public override void SortProduct()
        {
            products.Sort();
        }

        public override void ProductInfo()
        {
            Console.WriteLine($"There are {products.Count} products in {Name}:");
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }
    }
}
