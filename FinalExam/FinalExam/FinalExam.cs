using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExam
{
    public class FinalExam
    {
        private int majorObjectVersion = 1;
        private int minorObjectVersion = 1;
        public static int MajorVersion { get; set; } = 1;

        public static int MinorVersion { get; set; } = 0;
        public static string Version => $"{MajorVersion}.{MinorVersion}";

        /* inner class MyItem
         */
        private class MyItem: IComparable<MyItem>
        {
            // YOU implement properties for class MyItem
            public int Id { get; set; }
            public double Price { get; set; }
            public string Name { get; set; }

            public MyItem() // default MyItem constructor
            {
                Id = 1;
                Price = 0.99;
                Name = "some item";
            }
            /* ALL subclasses must override this method
             */
            public virtual string MyDescription()
            {
                return "I'm an item";
            }
            public override string ToString()
            {
                return $"#{Id} ${Price} {Name} '{MyDescription()}'";
            }
            public int CompareTo(MyItem other)
            {
                return this.Id.CompareTo(other.Id);
            }
            public static Comparison<MyItem> CompareId = delegate (MyItem item1, MyItem item2)
            {
                return item1.Id.CompareTo(item2.Id);
            };
            public static Comparison<MyItem> ComparePrice = delegate (MyItem item1, MyItem item2)
            {
                return item1.Price.CompareTo(item2.Price);
            };
            public static Comparison<MyItem> CompareName = delegate (MyItem item1, MyItem item2)
            {
                return string.Compare(item1.Name, item2.Name, StringComparison.CurrentCulture);
            };
            
            //public MyItem(string csvdata)
            //{
            //    string[] tokens = csvdata.Split(',');
            //    Id = ParseInt(tokens[0]);
            //    Name = tokens[1];
            //    Price = ParseDouble(tokens[2]);
            //}
        }

        /* YOU DESIGN inner class MyBread
         * derived from MyItem       
         */
        class MyBread : MyItem
        {
            public MyBread()
            {
                Id = 3;
                Price = 1.49;
                Name = "Bread"; 
            }
            public override string MyDescription()
            {
                return "I'm a bread";
            }
        }
        /* YOU DESIGN inner class MyOJ        
         * derived from MyItem       
         */
        class MyOJ : MyItem
        {
            public MyOJ()
            {
                Id = 2;
                Price = 3.49;
                Name = "OJ";
            }
            public override string MyDescription()
            {
                return "I'm an OJ";
            }
        }
        /* YOU DESIGN inner class MyMilk
         * derived from MyItem       
         */
        class MyMilk : MyItem
        {
            public MyMilk()
            {
                Id = 1;
                Price = 2.49;
                Name = "Milk";
            }
            public override string MyDescription()
            {
                return "I'm a milk";
            }
        }

        public FinalExam()
        {
            MajorVersion = majorObjectVersion;
            MinorVersion = minorObjectVersion;
        }
        /**
         * 
         * Method Name:     UseStrings
         * Parameters:      none
         * Return value:    none
         *         
         * Write to console: 
         *   1. interpolated string with expression 9 + 3
         *         
         * Example CONSOLE OUTPUT:
         * 
         * 9+3=9        
         */
        public void UseStrings()
        {
            Console.WriteLine("9+3=9");
        }
        /**
         * 
         * Method Name:     UseObjectInitializer
         * Parameters:      none
         * Return value:    none
         *         
         * Use Object Initializer
         * 
         * Instantiate the following objects:
         * 1. $1.49 Wheat Bread
         * 2. Dictionary of numbers: 1 is One, 2 is Two, 3 is Three        
         * 3. Dictionary of US States: NH is New Hampshire, NY is New York, NJ is New Jersey
         *         
         */
        public void UseObjectInitializer()
        {
            Console.WriteLine("\n\t FinalExam.UseObjectInitializer()...");
            Console.WriteLine("   (1)Instantiate the $1.49 Wheat Bread.");
            MyBread TracyBread = new MyBread { Id = 1, Name = "Wheat Bread", Price = 1.49 };
            Console.WriteLine($"{TracyBread.Price}  {TracyBread.Name} ");
            Console.WriteLine("   (2)Instantiate dictionary of numbers: 1 is One, 2 is Two, 3 is Three ");
            Dictionary<int, string> numberDictionary = new Dictionary<int, string>();
            Console.WriteLine("Dictionary of numbers:");
            numberDictionary.Add(1, "one");
            numberDictionary.Add(2, "two");
            numberDictionary.Add(3, "three");
            foreach(KeyValuePair<int, string> n in numberDictionary)
            {
                Console.WriteLine(n.Key + " is " + n.Value);
            }
            Console.WriteLine("   (3)Instantiate dictionary of US States: NH is New Hampshire, NY is New York, NJ is New Jersey");
            Dictionary<string, string> stateDictionary = new Dictionary<string, string>();
            Console.WriteLine("Dictionary of states:");
            stateDictionary.Add("NH", "New Hampshire");
            stateDictionary.Add("NY", "New York");
            stateDictionary.Add("NJ", "New Jersey");
            foreach(KeyValuePair<string, string> n in stateDictionary)
            {
                Console.WriteLine(n.Key + " is " + n.Value);
            }
            Console.WriteLine("\n\t FinalExam.UseObjectInitializer()...done!");
        }

        /**
         * 
         * Method Name:     ParseCSVString
         * Parameters:      none
         * Return value:    none
         *         
         * Demonstrate the parsing of a string containing 
         * three Comma Separated Value (CSV) tokens. 
         *  1. demonstrate parsing and conversion of an integer value;
         *  2. demonstrate parsing and conversion of a  string value;
         *  3. demonstrate parsing and conversion of a  double value;
         * 
         * NOTE: NO File I/O. Use a literall CSV string
         * parse tokens from Comma Separated Value (CSV) string
         * handle any thrown exceptions and write result to console
         *      e.g. 
         *  "17,Dan,4.0" Where Dan, age 17 having GPA of 4.0;
         * 
         */

        public void ParseCSVString()
        {
            Console.WriteLine("\n\t FinalExam.ParseCSVString()...");
            string csvDataTracy = "17,Dan,4.0";
            char delimiter = ',';
            string[] tokens = csvDataTracy.Split(delimiter);
            int age = ParseInt(tokens[0]);
            string name = tokens[1];
            double gpa = ParseDouble(tokens[2]);
            Console.WriteLine($"Where {name}, age {age} having gpa of " + gpa);
            int ParseInt(string s)
            {
                int n = 0;
                try
                {
                    n = Int16.Parse(s);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Can not parse string into int.");
                }
                return n;
            }
            double ParseDouble(string s)
            {
                double n = 0;
                try
                {
                    n = double.Parse(s);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Can not parse string into double.");
                }
                return n;
            }
            Console.WriteLine("\n\t FinalExam.ParseCSVString()...done!");
        }

/**
 * 
 * Method Name:     GenericShow<T>
 * Parameters:      list<T> list sequential container of elements of type T
 * Return value:    none
 *
 * Use generic programming to implement a method to show
 * the state of each element in a supplied list sequential container.        
 */

//public void GenericShow<T>(List<T> list)
//{
//    foreach(var element in T)
//    {
//    System.Console.Write($"{element}");
//    }

//}
/**
 * 
 * Method Name:     GenericSort<T>
 * Parameters:      list<T> list sequential container of elements of type T
 *                  Comparison<T> comparer        
 * Return value:    list<T> list sequential container of elements of type T
 *         
 * Sort a list using the supplied Comparison and return
 */
//public List<T> GenericSort<T>(List<T> list, Comparison<T> comparer)
//{
//    return list;
//}
/**
 * 
 * Method Name:     GenericSort<T>
 * Parameters:      string title
 *                  list<T> list sequential container of elements of type T
 *                  Comparison<T> comparer        
 * Return value:    list<T> list sequential container of elements of type T
 *         
 * Sort a list using the supplied Comparison and return
 */
//public List<T> GenericSort<T>(string title, List<T> list, Comparison<T> comparer)
//{
//    return list;
//}
/**
 * 
 * Method Name:     SortIntegers
 * Parameters:      none
 * Return value:    none
 *         
 * Write to console: 3, 1, 5, 2, 4 
 *  1. sorted ascending and descending using sort() and reverse();
 *  2. sorted descending and descending using Lambda; 
 *  3. sorted descending and descending using LINQ;
 *  4. sorted descending and descending using GenericSort<T>(); 
 *  5. sorted descending and descending using Anonymous Comparison delegate; 
 *  e.g.
 * 1, 2, 3, 4, 5, 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 5, 4, 3, 2, 1,  ... done! 
 */
public void SortIntegers()
        {
            Console.WriteLine($"\n\t FinalExam.SortIntegers()...");
            List<int> intList = new List<int> { 3, 1, 5, 2, 4 };
            foreach(int number in intList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("SORTED ASCENDING AND DESCENDING:");
            Console.WriteLine("   (1)Sorted ascending and descending using sort() and reverse();");
            intList.Sort();
            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
            intList.Reverse();
            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("   (2)Sorted ascending and descending using Lambda; ");
            intList.Sort((int1, int2) => int1.CompareTo(int2));
            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
            intList.Sort((int1, int2) => int1.CompareTo(int1));
            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("   (3)Sorted ascending and descending using LINQ;");
            var intAscending = intList.OrderBy(n => n);
            foreach (int number in intAscending)
            {
                Console.WriteLine(number);
            }
            var intDescending = intList.OrderByDescending(n => n);
            foreach (int number in intDescending)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("   (4)Sorted ascending and descending using GenericSort<T>(); ");
            int compareIntegerAscending(int x, int y)
            {
                return x.CompareTo(y);
            }
            intList.Sort(compareIntegerAscending);
            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
            int compareIntegerDescending(int x, int y)
            {
                return y.CompareTo(x);
            }
            intList.Sort(compareIntegerDescending);
            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("   (5)Sorted ascending and descending using Anonymous Comparison delegate; ");
            intList.Sort(delegate (int x, int y) { return x.CompareTo(y); });
            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
            intList.Sort(delegate (int x, int y) { return y.CompareTo(x); });
            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"\n\t FinalExam.SortIntegers()...done!");
        }
        /**
         * 
         * Method Name:     SortDoubles
         * Parameters:      none
         * Return value:    none
         *         
         * Write to console: 3.3, 1.1, 5.5, 2.2, 4.4 
         *  1. sorted ascending and descending using sort() and reverse();
         *  2. sorted descending and descending using Lambda; 
         *  3. sorted descending and descending using LINQ;
         *  4. sorted descending and descending using GenericSort<T>(); 
         *  5. sorted descending and descending using Anonymous Comparison delegate; 
         *  e.g.
         * 1.1, 2.2, 3.3, 4.4, 5.5, 5.5, 4.4, 3.3, 2.2, 1.1, 1.1, 2.2, 3.3, 4.4, 5.5, 5.5, 4.4, 3.3, 2.2, 1.1, 1.1, 2.2, 3.3, 4.4, 5.5, 5.5, 4.4, 3.3, 2.2, 1.1, 1.1, 2.2, 3.3, 4.4, 5.5, 5.5, 4.4, 3.3, 2.2, 1.1, 1.1, 2.2, 3.3, 4.4, 5.5, 5.5, 4.4, 3.3, 2.2, 1.1,  ... done! 
         */
        public void SortDoubles()
        {
            Console.WriteLine($"\n\t FinalExam.SortDoubles()...");
            List<double> doubleList = new List<double> { 3.3, 1.1, 5.5, 2.2, 4.4};
            foreach (double number in doubleList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("SORTED ASCENDING AND DESCENDING:");
            Console.WriteLine("   (1)Sorted ascending and descending using sort() and reverse();");
            doubleList.Sort();
            foreach (double number in doubleList)
            {
                Console.WriteLine(number);
            }
            doubleList.Reverse();
            foreach (double number in doubleList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("   (2)Sorted ascending and descending using Lambda; ");
            doubleList.Sort((int1, int2) => int1.CompareTo(int2));
            foreach (double number in doubleList)
            {
                Console.WriteLine(number);
            }
            doubleList.Sort((int1, int2) => int1.CompareTo(int1));
            foreach (double number in doubleList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("   (3)Sorted ascending and descending using LINQ;");
            var intAscending = doubleList.OrderBy(n => n);
            foreach (double number in doubleList)
            {
                Console.WriteLine(number);
            }
            var intDescending = doubleList.OrderByDescending(n => n);
            foreach (double number in doubleList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("   (4)Sorted ascending and descending using GenericSort<T>(); ");
            int compareDoubleAscending(double x, double y)
            {
                return x.CompareTo(y);
            }
            doubleList.Sort(compareDoubleAscending);
            foreach (double number in doubleList)
            {
                Console.WriteLine(number);
            }
            int compareDoubleDescending(double x, double y)
            {
                return y.CompareTo(x);
            }
            doubleList.Sort(compareDoubleDescending);
            foreach (double number in doubleList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("   (5)Sorted ascending and descending using Anonymous Comparison delegate; ");
            doubleList.Sort(delegate (double x, double y) { return x.CompareTo(y); });
            foreach (double number in doubleList)
            {
                Console.WriteLine(number);
            }
            doubleList.Sort(delegate (double x, double y) { return y.CompareTo(x); });
            foreach (double number in doubleList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"\n\t FinalExam.SortDoubles()...done!");
        }
        /**
         * 
         * Method Name:     SortStrings
         * Parameters:      none
         * Return value:    none
         *         
         * Write to console: Moe, Larry, Curley 
         *  1. sorted ascending and descending using sort() and reverse();
         *  2. sorted descending and descending using Lambda; 
         *  3. sorted descending and descending using LINQ;
         *  4. sorted descending and descending using GenericSort<T>(); 
         *  5. sorted descending and descending using Anonymous Comparison delegate; 
         *  e.g.
         * Curley, Larry, Moe, Moe, Larry, Curley, Curley, Larry, Moe, Moe, Larry, Curley, Curley, Larry, Moe, Moe, Larry, Curley, Curley, Larry, Moe, Moe, Larry, Curley, Curley, Larry, Moe, Moe, Larry, Curley,  ... done! 
         */
        public void SortStrings()
        {
            Console.WriteLine($"\n\t FinalExam.SortStrings()...");
            List<string> stringList = new List<string> { "Moe", "Larry", "Curley"};
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("SORTED ASCENDING AND DESCENDING:");
            Console.WriteLine("   (1)Sorted ascending and descending using sort() and reverse();");
            stringList.Sort();
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }
            stringList.Reverse();
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("   (2)Sorted ascending and descending using Lambda; ");
            stringList.Sort((string1, string2) => string.Compare(string1, string2, StringComparison.Ordinal));
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }
            stringList.Sort((string1, string2) => string.Compare(string2, string1, StringComparison.Ordinal));
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("   (3)Sorted ascending and descending using LINQ;");
            var stringAscending = stringList.OrderBy(n => n);
            foreach (string s in stringAscending)
            {
                Console.WriteLine(s);
            }
            var stringDescending = stringList.OrderByDescending(n => n);
            foreach (string s in stringDescending)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("   (4)Sorted ascending and descending using GenericSort<T>(); ");
            int compareStringAscending(string x, string y)
            {
                return string.Compare(x, y, StringComparison.Ordinal);
            }
            stringList.Sort(compareStringAscending);
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }
            int compareStringDescending(string x, string y)
            {
                return string.Compare(y, x, StringComparison.Ordinal);
            }
            stringList.Sort(compareStringDescending);
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("   (5)Sorted ascending and descending using Anonymous Comparison delegate; ");
            stringList.Sort(delegate (string x, string y) { return string.Compare(x, y, StringComparison.Ordinal); });
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }
            stringList.Sort(delegate (string x, string y) { return string.Compare(y, x, StringComparison.Ordinal); });
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine($"\n\t FinalExam.SortStrings()...done!");
        }
        /**
         * 
         * Method Name:     SortItems
         * Parameters:      none
         * Return value:    none
         *         
         * Demonstrate Sort on MyItems objects:
         *  1. sort by ID using Lambda;
         *  2. sort by Price (using default order);
         *  3. sort by Name using Lambda;
         */
        public void SortItems()
        {
            Console.WriteLine($"\n\t FinalExam.SortItems()...");
            List<MyItem> itemList = new List<MyItem>();
            itemList.Add(new MyItem { Id = 001, Name = "apple", Price = 0.99 });
            itemList.Add(new MyItem { Id = 025, Name = "banana", Price = 1.49 });
            itemList.Add(new MyItem { Id = 017, Name = "pineapple", Price = 5.99 });
            Console.WriteLine("SORTED BY ID ASCENDING AND DESCENDING:");
            Console.WriteLine("   (1.1)Sorted by Id ascending using Lambda");
            itemList.Sort((n1, n2) => n1.Id.CompareTo(n2.Id));
            foreach (MyItem item in itemList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   (1.2)Sorted by Id desscending using Lambda");
            itemList.Sort((n1, n2) => n2.Id.CompareTo(n1.Id));
            foreach (MyItem item in itemList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("SORTED BY PRICE ASCENDING AND DESCENDING:");
            Console.WriteLine("   (2.1)Sorted using default order");
            itemList.Sort();
            itemList.Sort((n1, n2) => n1.Price.CompareTo(n2.Price));
            foreach (MyItem item in itemList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("SORTED BY NAME ASCENDING AND DESCENDING:");
            Console.WriteLine("   (3.1)Sorted by Name ascending using Lambda");
            itemList.Sort((n1, n2) => string.Compare(n1.Name, n2.Name, StringComparison.Ordinal));
            foreach (MyItem item in itemList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   (3.2)Sorted by Name descending using Lambda");
            itemList.Sort((n1, n2) => string.Compare(n2.Name, n1.Name, StringComparison.Ordinal));
            foreach (MyItem item in itemList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\n\t FinalExam.SortItems()...done!");
        }
        /**
         * 
         * Method Name:     ProcessIntegers
         * Parameters:      none
         * Return value:    none
         *         
         * Demonstrate LINQ on int values, 3, 2, 1:
         *  1. sort in ascending order;
         *  2. scale each integer value by 100;
         * e.g.
         * 100, 200, 300,  ... done!
         */
        public void ProcessIntegers()
        {
            Console.WriteLine($"\n\t FinalExam.ProcessIntegers()...");
            List<int> intList = new List<int> { 3, 2, 1 };
            Console.WriteLine("   (1)Sort integers in ascending order.");
            var ProcessInteger = intList.OrderBy(n => n);
            foreach(int number in ProcessInteger)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("   (2)Scale each integer value by 100.");
            var ScaleInteger = intList.OrderBy(n => n).Select(n => n * 100);
            foreach(int number in ScaleInteger)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"\n\t FinalExam.ProcessIntegers()...done!");
        }
        /**
         * 
         * Method Name:     ProcessDoubles
         * Parameters:      none
         * Return value:    none
         *         
         * Demonstrate LINQ on double vlaues, 33.3, 22.2, 11.1:
         *  1. sort in ascending order;
         *  2. discount each double value by 20%;
         * e.g.
         * Original values => 33.3, 11.1, 22.2,  SORTED => 11.1, 22.2, 33.3,  and then discounted 20% => 8.88, 17.76, 26.64,  ... done!
         */
        public void ProcessDoubles()
        {
            Console.WriteLine($"\n\t FinalExam.ProcessDoubles()...");
            List<double> doubleList = new List<double> { 33.3, 22.2, 11.1 };
            Console.WriteLine("   (1)Sort doubles in ascending order.");
            var ProcessDouble = doubleList.OrderBy(n => n);
            foreach (double number in ProcessDouble)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("   (2)Discount each double value by 20%.");
            var DiscountDouble = doubleList.OrderBy(n => n).Select(n => n * 0.8);
            foreach (double number in DiscountDouble)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"\n\t FinalExam.ProcessDoubles()...done!");
        }
        /**
         * 
         * Method Name:     ProcessItems
         * Parameters:      none
         * Return value:    none
         *         
         * Demonstrate LINQ on MyItems objects:
         *  1. sort by ID ASCENDING AND DESCENDING using LINQ;
         *  2. sort by Price ASCENDING (use LINQ Query syntax) AND DESCENDING (use LINQ Fluent syntax);
         *  3. sort by Name ASCENDING AND DESCENDING using LINQ;
         *  4. Show a 10% price increase in each item
         */
        public void ProcessItems()
        {
            Console.WriteLine($"\n\t FinalExam.ProcessItems()...");
            List<MyItem> itemList = new List<MyItem>();
            itemList.Add(new MyItem { Id = 001, Name = "apple", Price = 0.99 });
            itemList.Add(new MyItem { Id = 025, Name = "banana", Price = 1.49 });
            itemList.Add(new MyItem { Id = 017, Name = "pineapple", Price = 5.99 });
            Console.WriteLine("   1.SORTED BY ID ASCENDING AND DESCENDING:");
            Console.WriteLine("   (1.1)Sort by Id ascending using Linq.");
            var SortByIdAscending = itemList.OrderBy(n => n.Id);
            foreach (MyItem item in SortByIdAscending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   (1.2)Sort by Id descending using Linq.");
            var SortByIdDescending = itemList.OrderByDescending(n => n.Id);
            foreach (MyItem item in SortByIdDescending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   2.SORTED BY PRICE ASCENDING AND DESCENDING:");
            Console.WriteLine("   (2.1)Sort by price ascending using Linq.");
            var SortByPriceAscending = itemList.OrderBy(n => n.Price);
            foreach (MyItem item in SortByPriceAscending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   (2.2)Sort by price descending using Linq.");
            var SortByPriceDescending = itemList.OrderByDescending(n => n.Price);
            foreach (MyItem item in SortByPriceDescending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   3.SORTED LINQ Query & Fluent BY PRICE ASCENDING AND DESCENDING:");
            Console.WriteLine("   (3.1)Sort by price ascending using Linq.");
            IEnumerable<MyItem> SortByPcAscending =
                itemList
                .OrderBy(n => n.Price)
                ;
            foreach (MyItem item in SortByPcAscending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   (3.2)Sort by price descending using Linq.");
            IEnumerable<MyItem> SortByPcDescending =
                itemList
                .OrderByDescending(n => n.Price)
                ;
            foreach (MyItem item in SortByPcDescending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   4.SORTED BY NAME ASCENDING AND DESCENDING:");
            Console.WriteLine("   (4.1)Sort by name ascending using Linq.");
            var SortByNameAscending = itemList.OrderBy(n => n.Name);
            foreach (MyItem item in SortByNameAscending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   (4.2)Sort by name descending using Linq.");
            var SortByNameDescending = itemList.OrderBy(n => n.Name);
            foreach (MyItem item in SortByPriceDescending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   5.SORTED BY PRICE showing 20% price increase:");
            var SortByPriceIncreasing = itemList.OrderBy(n => n.Price).Select(n=>new MyItem { Id = n.Id, Price = n.Price * 1.2, Name = n.Name });
            foreach (MyItem item in SortByPriceIncreasing)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   6.Anonymous Type SORTED BY PRICE showing 20% price increase:");
            var SortByPriceAnonymous = itemList.OrderBy(n => n.Price).Select(n => new MyItem { Id = n.Id, Price = n.Price * 1.2, Name = n.Name });
            foreach (MyItem item in SortByPriceAnonymous)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\n\t FinalExam.ProcessItems()...done!");
        }

        /**
         * 
         * Method Name:     UsePolymorphism
         * Parameters:      none
         * Return value:    none
         *         
         * Demonstrate polymorphism using MyItem objects:
         *  1. Derive MyBread, MyMilk and MyOJ classes from MyItem
         *  2. Instantiate objects, using object initializer:
         *      MyMilk  Id=1, Price=2.49, Name="Milk"
         *      MyOJ    Id=2, Price=3.49, Name="OJ"
         *      MyBread Id=3, Price=1.49, Name="Bread"
         *  1. sort by ID using LINQ;
         *  2. sort by Price using LINQ;
         *  3. sort by Name using LINQ (Query and Fluent syntax);
         */
        public void UsePolymorphism()
        {
            Console.WriteLine($"\n\t FinalExam.UsePolymorphism()...");
            List<MyItem> itemList = new List<MyItem>();
            itemList.Add(new MyMilk { Id = 1, Price = 2.49, Name = "Milk" });
            itemList.Add(new MyOJ { Id = 2, Price = 3.49, Name = "OJ" });
            itemList.Add(new MyBread { Id = 3, Price = 1.49, Name = "Bread" });
            Console.WriteLine("   (1)SORTED BY ID ASCENDING AND DESCENDING:");
            Console.WriteLine("   (1.1)Sort by Id ascending using Linq.");
            var SortByIdAscending = itemList.OrderBy(n => n.Id);
            foreach(MyItem item in SortByIdAscending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   (1.2)Sort by Id descending using Linq.");
            var SortByIdDescending = itemList.OrderByDescending(n => n.Id);
            foreach (MyItem item in SortByIdDescending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   (2)SORTED BY PRICE ASCENDING AND DESCENDING:");
            Console.WriteLine("   (2.1)Sort by price ascending using Linq.");
            var SortByPriceAscending = itemList.OrderBy(n => n.Price);
            foreach (MyItem item in SortByPriceAscending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   (2.2)Sort by price descending using Linq.");
            var SortByPriceDescending = itemList.OrderByDescending(n => n.Price);
            foreach (MyItem item in SortByPriceDescending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   (3)SORTED LINQ Query & Fluent BY PRICE ASCENDING AND DESCENDING:");
            Console.WriteLine("   (3.1)Sort by name ascending using Linq.");
            IEnumerable<MyItem> SortByNameAscending =
                itemList
                .OrderBy(n => n.Name)
                ;
            foreach (MyItem item in SortByNameAscending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("   (3.2)Sort by name descending using Linq.");
            IEnumerable<MyItem> SortByNameDescending =
                itemList
                .OrderByDescending(n => n.Name)
                ;
            foreach (MyItem item in SortByPriceDescending)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\n\t FinalExam.UsePolymorphism()...done!");
        }

        /*
         * 60 POINTS:       
         */
        public static void Demo()
        {
            Console.WriteLine($"\n\t FinalExam.Demo() version {Version} ...");

            FinalExam obj = new FinalExam();

            obj.UseStrings();           //  2 POINTS
            obj.UseObjectInitializer(); //  4 POINTS
            obj.ParseCSVString();       //  4 POINTS

            obj.SortIntegers();         //  2 POINTS
            obj.SortDoubles();          //  2 POINTS
            obj.SortStrings();          //  6 POINTS
            obj.SortItems();            // 10 POINTS

            obj.ProcessIntegers();      // 5 POINTS
            obj.ProcessDoubles();       // 5 POINTS
            obj.ProcessItems();         // 10 POINTS

            obj.UsePolymorphism();      // 10 POINTS

            Console.WriteLine("\n\t FinalExam.Demo()...done!");
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
