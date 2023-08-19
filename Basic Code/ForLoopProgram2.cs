using System;
namespace SiddCodes{
    class ForLoopProgram2{
        static void Main(string[] args){
            for(int i=0;i<10;i++){
                if(i==5){
                    //leave this loop forever.
                    break;
                }
                Console.WriteLine(i+1);
            }
            for(int i=0;i<10;i++){
                if(i==8){
                    //Leave the particular itaration of the loop.
                    continue;
                }
                Console.WriteLine(i+1);
            }
            Console.ReadLine();
        }
    }
}