using System;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This is Tracy's Final Exam Project!");
            FinalExam.Demo();


            Console.WriteLine("Part2: 15 Points");
            Console.WriteLine("Adding the requires MyBread, MyMilk and MyPJ inner classes derived from MyIte.");
            Console.WriteLine("Part2 ... done!");


            Console.WriteLine("Part3: 10 Points");
            Console.WriteLine("   (1)Adding properties int Id, double Price and string Name");
            //itemList.AddItem("101,apple,0.99");
            //itemList.AddItem("020,banana,1.99");
            //itemList.AddItem("056,pineapple,6.99");
            //Console.WriteLine("   (2)Implement Comparable.");
            //itemList.CompareName(FinalExam.CompareName);
            //itemList.ExhibitItem();
            //Console.WriteLine("   (2.1)Comparable by Name.");
            //itemList.ComparePrice(FinalExam.ComparePrice);
            //itemList.ExhibitItem();
            //Console.WriteLine("   (2.2)Comparable by Price.");
            //itemList.CompareId(FinalExam.CompareId);
            //itemList.ExhibitItem();
            //Console.WriteLine("   (2.3)Comparable by Id.");
            Console.WriteLine("Part3 ... done!");

            Console.WriteLine("Part4: 15 Points.");
            Console.WriteLine("Demonstrate the use of a Publisher/Subscriber event with Threads.");
            var dealer = new BookDealer();   //Publisher
            Console.WriteLine("   (1)Create three students and subscribe the Publisher.");
            var tracy = new Student("Tracy");
            var bo = new Student("Bo");
            var yuelong = new Student("Yuelong");
            dealer.NewBookInfo += tracy.NewBookIsHere;  //subscribe
            dealer.NewBookInfo += bo.NewBookIsHere;
            dealer.NewBookInfo += yuelong.NewBookIsHere;
            dealer.NewBook("TOEFL"); // Publish Event
            Console.WriteLine("   (2)One student cancle subscribe and then publish another event.");
            dealer.NewBookInfo -= tracy.NewBookIsHere;
            dealer.NewBook("Programming"); // Publish Event
            Console.WriteLine("Part4 ... done!");
        }
    }
}
