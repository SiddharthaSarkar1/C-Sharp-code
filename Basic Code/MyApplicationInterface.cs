using System;
namespace MyApplicationInterface{
    //Interface
    interface IAnimal{
        //Interface Method (does not have body)
        void animalSound();
    }
    class Pig : IAnimal{
        //For method animalSound() body is provided here
        public void animalSound(){
            Console.WriteLine("The pig says, wee wee!!!");
        }
    }
    class MainMethodInter{
        static void Main(string[] args){
            Pig myPig = new Pig();
            myPig.animalSound();
        }
    }
}