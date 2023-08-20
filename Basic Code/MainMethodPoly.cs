using System;
//Polymorphism
namespace MyApplication{
    class Animal{
        //In C#, a virtual method is a method that can be overridden in a derived class. When a method is declared as virtual in a base class, it allows a derived class to provide its own implementation of the method.
        public virtual void animalSound(){
            Console.WriteLine("The animal makes a sound.");
        }
    }
    class Pig : Animal{
        public override void animalSound(){
            Console.WriteLine("The pig says, wee wee!!!");
        }
    }
    class Cat : Animal{
        public override void animalSound(){
            Console.WriteLine("The cat says, meao meao!!!");
        }
    }
    class Dog : Animal{
        public override void animalSound(){
            Console.WriteLine("The dog says, bhow whow!!!");
        }
    }
    class MainMethodPoly{
        static void Main(string[] args){
            Animal myAnimal = new Animal();
            Pig myPig = new Pig();
            Cat myCat = new Cat();
            Dog myDog = new Dog();
            
            myAnimal.animalSound();
            myPig.animalSound();
            myCat.animalSound();
            myDog.animalSound();
        }
    }
}