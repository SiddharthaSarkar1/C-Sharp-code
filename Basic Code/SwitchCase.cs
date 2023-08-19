using System;
namespace SiddCodes{
    class SwitchCase{
        static void Main(string[] args){
            Console.WriteLine("Enter your age : ");
            string ageStr = Console.ReadLine();
            int age = Convert.ToInt32(ageStr);
            switch(age){
                case 18:
                Console.WriteLine("Please wait for an year.");
                break;
                case 20:
                Console.WriteLine("You are 20.");
                break;
                default:
                Console.WriteLine("Enjoy!!");
                break;
            }
            Console.ReadLine();
        }
    }
}