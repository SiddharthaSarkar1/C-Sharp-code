using System;
namespace SiddCodes{
    class TryCatchProgram{
        static void Main(string[] args){
            try{
                int[] number = {1, 2, 3, 4, 5};
                Console.WriteLine(number[8]);
                
            }catch(Exception e){
                Console.WriteLine("Something went WRONG!!!");
                Console.WriteLine("ERROR MESSAGE : " + e);
            }
        }
    }
}