using System;

namespace SiddCodes{
    class IfElseIf{
        static void Main(string[] args){
            Console.WriteLine("Please enter your age : ");
            string ageStr = Console.ReadLine();
            int age = Convert.ToInt32(ageStr);
            
            if(age < 2){
                Console.WriteLine("You are just born.");
            }else if(age < 10){
                Console.WriteLine("Please finish your high school.");
            }else if(age < 18){
                Console.WriteLine("You are below 18.");
            }else if(age < 75){
                Console.WriteLine("You can drive.");
            }else{
                Console.WriteLine("You can't drive.");
            }
            Console.ReadLine();
        }
    }
}