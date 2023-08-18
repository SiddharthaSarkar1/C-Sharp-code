using System;

namespace SiddCode{
    class TypeCasting{
        static void Main(string[] args){
            Console.WriteLine("Enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter number of candies you want :");
            string candy = Console.ReadLine();
            Console.WriteLine($"Your name is {name}, you will get {candy} candies.");
            Console.ReadLine();
        }
    }
}