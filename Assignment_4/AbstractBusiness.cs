using System;
using System.Collections.Generic;

namespace MidTerm
{
    public abstract class AbstractBusiness
    {
       
        public abstract void AddEmployee(Employee employee);
        public abstract void AddClient(AbstractPerson e);
        public abstract void AddProduct(Product product);

        public abstract void SortEmployee(object compareByAge);
        public abstract void SortClient();
        public abstract void SortProduct();

        public abstract void EmployeeInfo();
        public abstract string ClientInfo();
        public abstract void ProductInfo();

        public abstract void SortEmployee(Comparison<AbstractPerson> comparison);
        public abstract void SortProduct(Comparison<Product> comparison);

    }
}
/*
 * IBM Program 100 TOTAL POINTS
 * 
 * 10 Points:
 * - Complete AbstractBusiness class by adding:
 *    - an abstract method to overload SortEmployees by any property as specified by supplied parameter;
 *    - an abstract method to overload SortClients by any property as specified by supplied parameter;
 *    - an abstract method to overload SortItems by any property as specified by supplied parameter;
 * 
 * 20 Points:
 * - Derive class Company from AbstractBusiness with properties Id,Name and Lists for employees, clients and products as follows:
 *      private List<AbstractPerson> employees = new List<AbstractPerson>();
 *      private List<AbstractPerson> clients = new List<AbstractPerson>();
 *      private List<Product> products = new List<Product>();
 * 
 * 10 Points:
 * - Create interface IBillable with two methods:
 *      int GetUsage()
 *      decimal GetCharges(int multiplier, decimal fees)
 * - Derive class CustomerOffering from Product and IBillable;
 * - Derive class ServiceProduct from CustomerOffering;
 * - Derive class LicensedProduct from CustomerOffering;
 * 
 * 20 Points:
 * - Create and use factories (Factory Design pattern) for creating objects.
 * 
 * 30 Points:
 * - Derive class Ibm from Company, and complete and use the following Demo() method:
 * 
        public static void Demo()
        {
            Console.WriteLine("\n\t Ibm.Demo()... ");

            AbstractCompanyFactory f = new IbmFactory();
            Company ibm = f.GetObject();
                       
            AbstractPersonFactory fEmployee = new EmployeeFactory();
            ibm.AddEmployee(fEmployee.GetObject("2,Sam,Adams,38,1002,35.25"));
            ibm.AddEmployee(fEmployee.GetObject("3,Pam,Jones,28,1003,55.35"));
            ibm.AddEmployee(fEmployee.GetObject("4,An,Wang,88,1004,95.45"));

            Console.WriteLine(ibm);

            Console.WriteLine("Sort by DEFAULT ORDER (LAST NAME)");
            ibm.SortEmployee();
            Console.WriteLine(ibm);

            Console.WriteLine("Sort by ID");
            // use overloaded ibm.SortEmployee(Type arg) method here 
            Console.WriteLine(ibm);

            Console.WriteLine("Sort by AGE");
            // use overloaded ibm.SortEmployee(Type arg) method here 
            Console.WriteLine(ibm);

            Console.WriteLine("Sort by FIRST NAME");
            // use overloaded ibm.SortEmployee(Type arg) method here 
            Console.WriteLine(ibm);

            Console.WriteLine("Sort by LAST NAME");
            // use overloaded ibm.SortEmployee(Type arg) method here 
            Console.WriteLine(ibm);

            Console.WriteLine("IBM CORP with Product Offerings:");
            AbstractCustomerOfferingFactory fLProducts = new LicencedProductFactory();
            AbstractCustomerOfferingFactory fSProducts = new ServiceProductFactory();
            ibm.AddProduct(fSProducts.GetObject("1,699.99,IBMWEB,IBM Internet Website Services"));
            ibm.AddProduct(fLProducts.GetObject("2,499.99,IBMPOS,IBM Retail Point of Sale application suite"));
            ibm.AddProduct(fSProducts.GetObject("3,1199.99,IBMCare,IBM Total Support Services"));
            ibm.AddProduct(fLProducts.GetObject("4,299.99,IBMPAY,IBM Employee and Payroll application suite"));
            ibm.AddProduct(fSProducts.GetObject("5,199.99,IBMCLOUD,IBM Network Server Cloud Services"));
            Console.WriteLine(ibm);

            Console.WriteLine("Sort by NATURAL ORDER (Product Price)");
            ibm.SortProduct();
            Console.WriteLine(ibm);

            Console.WriteLine("Sort by Product ID");
            ibm.SortProduct(Product.SortById);
            Console.WriteLine(ibm);

            Console.WriteLine("Sort by Product Price");
            ibm.SortProduct(Product.SortByPrice);
            Console.WriteLine(ibm);

            Console.WriteLine("Sort by Product NAME");
            ibm.SortProduct(Product.SortByName);
            Console.WriteLine(ibm);

            Console.WriteLine("Sort by Product Description");
            ibm.SortProduct(Product.SortByDescription);
            Console.WriteLine(ibm);

            Console.WriteLine("\n\t Ibm.Demo()... done!");
        }
 *
 * NOTE: 
 *  Console.WriteLine(ibm) MUST display all object state on console including:
 *      - all employees: id,firstname,lastname,age,employeeid,wage
 *      - all products:  productid,price,name,description
 */

