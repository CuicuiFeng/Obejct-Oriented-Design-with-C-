using System;
namespace Practice_animal
{
    public class Animal
    {
        public Animal()
        {
        }
        virtual public void Speak() //Speak methos in class Animal
            // C# alloes virtual method to be overridden by derived class that implements
            // same identical method signature.
        {
            Console.WriteLine("I am an animal.");
        }
    }
}
