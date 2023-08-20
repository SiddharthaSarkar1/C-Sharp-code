using System;
//Inheritence
namespace MyApp{
    class Vehicle{
        public string brand = "Ford";
        public void honk(){
            Console.WriteLine("tuut,tuut!!!");
        }
    }
    class Car : Vehicle{
        public string modelName = "Mustang";
    }
    class MainClass{
        static void Main(string[] args){
            Car car = new Car();
            car.honk();
            Console.WriteLine(car.brand);
            Console.WriteLine(car.modelName);
        }
    }
}