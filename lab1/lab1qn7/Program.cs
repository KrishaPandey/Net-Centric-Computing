using System;

namespace lab1qn7
{
    class Animal
    {
      public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
    public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    class Program
    {
        static void Main()
        {
            
            Animal genericAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            Console.WriteLine("Generic Animal:");
            genericAnimal.MakeSound();

            Console.WriteLine("\nMy Dog:");
            myDog.MakeSound();

            Console.WriteLine("\nMy Cat:");
            myCat.MakeSound();

            Console.ReadLine();
        }
    }


}
