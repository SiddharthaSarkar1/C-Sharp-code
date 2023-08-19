using System;
namespace SiddCodes{
    class MethodProgram{
        static void MorningGreet(){
            Console.WriteLine("Good Morning!!!");
        }
        static void Greet(string name){
            Console.WriteLine($"Hello {name}");
        }
        static void Main(string[] args){
            Greet("Sidd");
            Greet("Andy");
            MorningGreet();
            Console.ReadLine();
        }
    }
}