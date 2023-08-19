using System;
namespace SiddCodes{
    class Car{
        
            public string model;
            
            public Car(){
                model = "Mustang";
            }
        static void Main(string[] args){
            Car car = new Car();
            Console.WriteLine(car.model);
        }
    }
}