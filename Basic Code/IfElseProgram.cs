using System;
namespace SiddCodes{
    class IfElseProgram{
        static void Main(string[] args){
            Console.WriteLine("Enter your age :");
            string age = Console.ReadLine();
            int user_age = Convert.ToInt32(age);
            if (user_age > 18){
                Console.WriteLine("You can drive.");
            }else{
                Console.WriteLine("You can't drive.");
                
            }
            Console.ReadLine();
        }
    }
}