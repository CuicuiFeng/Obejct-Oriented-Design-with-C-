using System;
namespace MidTerm
{
    public class Ibm : Company
    {
        public Ibm()
        {
            Name = "Ibm";
        }
        public Ibm(string name)
        {
            Name = name;
        }

        public static void Demo()
        {
            Console.WriteLine("\n\t Ibm.Demo()... ");

            //AbstractCompanyFactory f = new IbmFactory();
            //Company ibm = f.GetObject();
            Ibm ibm = new Ibm();

            //AbstractPersonFactory fEmployee = new EmployeeFactory();

            ibm.AddEmployee(new Employee(2,38,"Sam","Adams",1002,35.25));
            ibm.AddEmployee(new Employee(3,28, "Pam","Jones",1003,55.35));
            ibm.AddEmployee(new Employee(4,88, "An","Wang",1004,95.45));
            ibm.EmployeeInfo();
            //ibm.AddEmployee(fEmployee.GetObject("2,Sam,Adams,38,1002,35.25"));
            //ibm.AddEmployee(fEmployee.GetObject("3,Pam,Jones,28,1003,55.35"));
            //ibm.AddEmployee(fEmployee.GetObject("4,An,Wang,88,1004,95.45"));
            //Console.WriteLine(ibm);

            Console.WriteLine("Sort by DEFAULT ORDER (LAST NAME)");
            ibm.SortEmployee();
            ibm.EmployeeInfo();
            //Console.WriteLine(ibm);

            Console.WriteLine("Sort by ID");
            ibm.SortEmployee();
            ibm.EmployeeInfo();
            // use overloaded ibm.SortEmployee(Type arg) method here 
            //Console.WriteLine(ibm);

            Console.WriteLine("Sort by AGE");
            //ibm.SortEmployee((Employee e1, Employee e2) => e2.Age.CompareTo(e1.Age));
            //ibm.SortEmployee();
            //ibm.SortById();
            ibm.EmployeeInfo();
            // use overloaded ibm.SortEmployee(Type arg) method here 
            //Console.WriteLine(ibm);

            Console.WriteLine("Sort by FIRST NAME");
            ibm.SortEmployee();
            ibm.EmployeeInfo();
            // use overloaded ibm.SortEmployee(Type arg) method here 
            //Console.WriteLine(ibm);

            // use overloaded ibm.SortEmployee(Type arg) method here 
            //Console.WriteLine(ibm);

            //Console.WriteLine("IBM CORP with Product Offerings:");
            //AbstractCustomerOfferingFactory fLProducts = new LicencedProductFactory();
            //AbstractCustomerOfferingFactory fSProducts = new ServiceProductFactory();
            ibm.AddProduct(new Product(1,699.99,"IBMWEB","IBM Internet Website Services"));
            ibm.AddProduct(new Product(2,499.99,"IBMPOS","IBM Retail Point of Sale application suite"));
            ibm.AddProduct(new Product(3,1199.99,"IBMCare","IBM Total Support Services"));
            ibm.AddProduct(new Product(4,299.99,"IBMPAY","IBM Employee and Payroll application suite"));
            ibm.AddProduct(new Product(5,199.99,"IBMCLOUD","IBM Network Server Cloud Services"));
            //Console.WriteLine(ibm);
            ibm.ProductInfo();
            Console.WriteLine("Sort by Product NAME");
            ibm.SortProduct();
            ibm.ProductInfo();

            //Console.WriteLine("Sort by NATURAL ORDER (Product Price)");
            //ibm.SortProduct();
            //Console.WriteLine(ibm);

            //Console.WriteLine("Sort by Product ID");
            //ibm.SortProduct(Product.SortById);
            //Console.WriteLine(ibm);

            //Console.WriteLine("Sort by Product Price");
            //ibm.SortProduct(Product.SortByPrice);
            //Console.WriteLine(ibm);

            //Console.WriteLine("Sort by Product NAME");
            //ibm.SortProduct(Product.SortByName);
            //Console.WriteLine(ibm);

            //Console.WriteLine("Sort by Product Description");
            //ibm.SortProduct(Product.SortByDescription);
            //Console.WriteLine(ibm);

            Console.WriteLine("\n\t Ibm.Demo()... done!");
        }

        private void SortEmployee(Func<Employee, Employee, int> p)
        {
            throw new NotImplementedException();
        }
    }
}
