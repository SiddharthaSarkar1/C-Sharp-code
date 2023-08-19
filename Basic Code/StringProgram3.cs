using System;

namespace SiddCodes{
    class StringProgram3{
        static void Main(string[] args){
            string var = "Hello world this os Sidd";
            Console.WriteLine("Index of \"is\" ==>" + var.IndexOf("is"));
            Console.WriteLine("==========");
            Console.WriteLine(var.Substring(5));
            
            Console.WriteLine("Double coute \"Hello\"");
            Console.WriteLine("Double coute \n hello world");
            Console.WriteLine("Double coute \t hello world");
            Console.ReadLine();
        }
    }
}