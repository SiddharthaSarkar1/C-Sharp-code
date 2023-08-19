using System;
namespace SiddCodes{
    class Car{
            public string model;
            public string color;
            public int year;
            
            public Car(string model, string color, int year){
                this.model = model;
                this.color = color;
                this.year = year;
            }
            
            static void Main(string[] args){
                Car car = new Car("Mustang", "Red", 2023);
                Car car2 = new Car("BMW", "Blue", 2021);
                Console.WriteLine(car.model+" "+car.color+" "+car.year);
                Console.WriteLine(car2.model+" "+car2.color+" "+car2.year);
            }
    }
}