using System;
using System.Collections.Generic;

namespace MidTerm
{
    public class Company : AbstractBusiness
    {
        //public string Name { get; set; }
        //private List<Employee> employees = null;
        //private List<Product> products = null;
        private List<AbstractPerson> employees = new List<AbstractPerson>();
        private List<AbstractPerson> clients = new List<AbstractPerson>();
        private List<Product> products = new List<Product>();

        public void ShowInfo()
        {
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        public override void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }

        public override void SortEmployee(object compareByAge)
        {
            employees.Sort(Person.CompareByID);
        }

        public override void EmployeeInfo()
        {
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }

        public override void AddClient(AbstractPerson e)
        {
            this.clients.Add(e);
        }

        public override void SortClient()
        {
            throw new NotImplementedException();
        }

        public override string ClientInfo()
        {
            throw new NotImplementedException();
        }

        public override void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public override void SortProduct()
        {
            products.Sort(Product.CompareById);
        }

        public override void ProductInfo()
        {
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        public override void SortEmployee(Comparison<AbstractPerson> comparison)
        {
            employees.Sort(comparison);
        }

        public override void SortProduct(Comparison<Product> comparison)
        {
            products.Sort(comparison);
        }
    }
}
