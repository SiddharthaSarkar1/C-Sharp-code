using System;
namespace SiddCodes{
    class DoWhileLoopProgram{
        static void Main(string[] args){
            int i = 0;
            do{
                Console.WriteLine(i);
                i++;
            }while(i<50);
            Console.ReadLine();
        }
    }
}