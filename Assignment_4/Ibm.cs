using System;
using System.Collections.Generic;

namespace MidTerm
{
    public class Ibm : Company
    {
        public Ibm() { }

        public static void Demo()
        {
            Console.WriteLine("\n\t Ibm.Demo()... ");

            AbstractCompanyFactory f = new IbmFactory();
            Company ibm = f.GetObject();

           
            AbstractPersonFactory fEmployee = new EmployeeFactory();
            ibm.AddEmployee(fEmployee.GetObject("2,Sam,Adams,38,1002,35.25"));
            ibm.AddEmployee(fEmployee.GetObject("3,Pam,Jones,28,1003,55.35"));
            ibm.AddEmployee(fEmployee.GetObject("4,An,Wang,88,1004,95.45"));
            ibm.AddEmployee(fEmployee.GetObject("77,Becky,Fang,8,1004,95.45"));
            ibm.ShowInfo();

            Console.WriteLine("Sort by DEFAULT ORDER (LAST NAME)");
            ibm.SortEmployee(Person.CompareByLastName);
            ibm.ShowInfo();


            Console.WriteLine("Sort by ID");
            ibm.SortEmployee(Person.CompareByID);
            ibm.ShowInfo();

            Console.WriteLine("Sort by AGE");
            ibm.SortEmployee(Person.CompareAge);
            ibm.ShowInfo();

            Console.WriteLine("Sort by FIRST NAME");
            ibm.SortEmployee(Person.CompareByFirstName);
            ibm.ShowInfo();

            Console.WriteLine("\n IBM CORP with Product Offerings:");
            AbstractCustomerOfferingFactory fLProducts = new LicensedProductFactory();
            AbstractCustomerOfferingFactory fSProducts = new ServiceProductFactory();
            //List<Product> products = new List<Product>();
            ibm.AddProduct(fSProducts.GetObject("1,699.99,IBMWEB,IBM Internet Website Services"));
            ibm.AddProduct(fLProducts.GetObject("2,499.99,IBMPOS,IBM Retail Point of Sale application suite"));
            ibm.AddProduct(fSProducts.GetObject("3,1199.99,IBMCare,IBM Total Support Services"));
            ibm.AddProduct(fLProducts.GetObject("4,299.99,IBMPAY,IBM Employee and Payroll application suite"));
            ibm.AddProduct(fSProducts.GetObject("5,199.99,IBMCLOUD,IBM Network Server Cloud Services"));
            ibm.AddProduct(fSProducts.GetObject("7,3.99,Cloud,Test order"));
            ibm.ProductInfo();

            Console.WriteLine("\n Sort by NATURAL ORDER (Product Price)");
            ibm.ShowInfo();

            Console.WriteLine("\n Sort by Product NAME");
            ibm.ShowInfo();

            Console.WriteLine("\n Sort by Product ID");
            ibm.SortProduct(Product.CompareById);
            ibm.ShowInfo();

            Console.WriteLine("\n Sort by Product Price");
            ibm.SortProduct(Product.CompareByPrice);
            ibm.ShowInfo();

            Console.WriteLine("\n Sort by Product NAME");
            ibm.SortProduct(Product.CompareByName);
            ibm.ShowInfo();

            Console.WriteLine("\n Sort by Product Description");
            ibm.SortProduct(Product.CompareByDescription);
            ibm.ShowInfo();


            Console.WriteLine("\n\t Ibm.Demo()... done!");
        }
    }
}
