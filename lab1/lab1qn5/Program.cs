using System;

namespace lab1qn5
{
    // Single Inheritance
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Another class for Single Inheritance
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    // Multiple Inheritance with Interfaces
    interface IDrive
    {
        void Drive();
    }

    interface IFly
    {
        void Fly();
    }

    class FlyingCar : IDrive, IFly
    {
        public void Drive()
        {
            Console.WriteLine("FlyingCar is driving.");
        }

        public void Fly()
        {
            Console.WriteLine("FlyingCar is flying.");
        }
    }

    // Multilevel Inheritance
    class A
    {
        public void MethodA()
        {
            Console.WriteLine("Class A - Method A");
        }
    }

    class B : A
    {
        public void MethodB()
        {
            Console.WriteLine("Class B - Method B");
        }
    }

    class C : B
    {
        public void MethodC()
        {
            Console.WriteLine("Class C - Method C");
        }
    }

    // Hierarchical Inheritance
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }

    class Program
    {
        static void Main()
        {
            // Single Inheritance
            Animal animal = new Animal();
            animal.Eat();

            // Another Single Inheritance
            Bird bird = new Bird();
            bird.Eat();
            bird.Fly();

            // Multiple Inheritance with Interfaces
            FlyingCar flyingCar = new FlyingCar();
            flyingCar.Drive();
            flyingCar.Fly();

            // Multilevel Inheritance
            C cObj = new C();
            cObj.MethodA();
            cObj.MethodB();
            cObj.MethodC();

            // Hierarchical Inheritance
            Shape circle = new Circle();
            Shape square = new Square();

            circle.Draw();
            square.Draw();

            Console.ReadLine();
        }
    }
}
