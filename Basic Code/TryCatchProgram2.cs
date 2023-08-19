using System;
namespace SiddCodes{
    class TryCatchProgram2{
        static void Main(string[] args){
            try{
                int[] number = {1, 2, 3, 4, 5};
                // Console.WriteLine(number[8]);
                Console.WriteLine(number[3]);
                
            }catch(Exception e){
                Console.WriteLine("Something went WRONG!!!");
                Console.WriteLine("ERROR MESSAGE : " + e);
            }finally{
                Console.WriteLine("Hello from finally block.");
                Console.WriteLine("the \"try catch \" is finished.");
            }
        }
    }
}