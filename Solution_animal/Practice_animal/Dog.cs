using System;
namespace Practice_animal
{
    public class Dog : Animal
    {
        public Dog()
        {
        }

        public override void Speak()
        {
            Console.WriteLine("I am a dog.");
        }
    }
}
