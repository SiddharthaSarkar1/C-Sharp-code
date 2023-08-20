using System;
namespace MyApplication{
    enum Level{
        Low,
        Medium,
        High
    }
    class MainMethodEnum{
        static void Main(string[] args){
            Level myLevelM = Level.Medium;
            Level myLevelH = Level.High;
            Console.WriteLine(myLevelM);
            Console.WriteLine(myLevelH);
        }
    }
}