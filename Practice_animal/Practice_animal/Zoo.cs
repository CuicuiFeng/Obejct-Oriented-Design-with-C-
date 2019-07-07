using System;
namespace Practice_animal
{
    public class Zoo
    {
        private System.Collections.Generic.List<Animal> animals = null;

        public Zoo()
        {
            this.animals = new System.Collections.Generic.List<Animal>();
        }

        public void Add(Animal o)
        {
            this.animals.Add(o);
        }

        public void Show()
        {
            foreach(Animal animal in this.animals)
            {
                animal.Speak();
            }
        }

        public static void demo()
        {
            Zoo obj = new Zoo();
            obj.Add(new Animal());
            obj.Add(new Dog());
            obj.Show();
        }
    }
}
