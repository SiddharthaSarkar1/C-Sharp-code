using System;
namespace SiddCodes{
    class MethodProgram2{
        static float Average(int a, int b, int c){
            int sum = a+b+c;
            return sum/3;
        }
        static void Main(string[] args){
            float val = Average(10,15,20);
            Console.WriteLine(val);
            Console.ReadLine();
        }
    }
}