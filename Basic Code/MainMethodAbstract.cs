using System;
namespace MyApplicationAbstraction{
    //Abstract Class
    abstract class Animal{
        //Abstract Method(does not have body)
        public abstract void animalSound();
        //Regular Method
        public void sleep(){
            Console.WriteLine("Zzzzz....");
        }
    }
    class Dog : Animal{
        //animalSound() body is provided here
        public override void animalSound(){
            Console.WriteLine("The dog says, bhow whow!!!");
        }
    }
    class MainMethodAbstract{
        static void Main(string[] args){
            Dog dog = new Dog();
            dog.sleep();
            dog.animalSound();
        }
    }
}