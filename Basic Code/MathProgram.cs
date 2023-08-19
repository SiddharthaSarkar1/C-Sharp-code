using System;

namespace SiddCodes{
    class MathProgram{
        static void Main(string[] args){
            int res = Math.Max(35, 355);
            Console.WriteLine(res);

            Console.WriteLine(Math.Min(5, 10));  
            
            double num = Math.Sqrt(49);
            Console.WriteLine(num);
            
            int numAbs = Math.Abs(-39);
            Console.WriteLine(numAbs);
        }
    }
}