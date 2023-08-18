using System;

namespace SiddCoding{
    class StringProgram2{
        static void Main(string[] args){
            string myVar = "Hello world, this is Sidd.";
            Console.WriteLine(myVar);
            Console.WriteLine(myVar.Length);
            Console.WriteLine(myVar.ToUpper());
            Console.WriteLine(myVar.ToLower());
            Console.WriteLine(myVar + "I have started learning C#.");
            Console.WriteLine(string.Concat(myVar, "I have started learning C#."));
            Console.ReadLine();
        }
    }
}