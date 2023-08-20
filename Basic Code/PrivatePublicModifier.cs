using System;
namespace SiddCodes{
    class Car{
        private string model = "Mustang";
        public string color = "Color";
    }
    class Public{
        static void Main(string[] args){
            try{
                Car c = new Car();
                // Console.WriteLine(c.model);
                Console.WriteLine(c.color);
            }catch(Exception e){
                Console.WriteLine("Error!!!");
                Console.WriteLine(e);
            }
        }
    }
}