using System;

namespace SiddCode{
    class TypeCasting{
        static void Main(string[] args){
            //Implicit Typecasting
            //(char to int to long to float to double)
            int x = 4;
            double y = x;
            Console.WriteLine(y);
            
            int a = (int)3.5;
            int b = (int)7.3;
            Console.WriteLine(a);
            
            //Explicit TypeCasting
            
            int p = 3;
            double d = (double)3.5;
            int e = (int)7.6;
            Console.WriteLine(d);
            Console.WriteLine(e);
            
            float varF = 33.54F;
            Console.WriteLine(varF);
            int varInt = Convert.ToInt32(varF);
            Console.WriteLine(varInt);
            
            double varDbl = Convert.ToDouble(varF);
            Console.WriteLine(varDbl);
            
            int var2 = 123456789;
            string varstr = Convert.ToString(var2);
            Console.WriteLine(varstr);
            
        }
    }
}