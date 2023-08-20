using System;
namespace MyApplicatioMultiInterfaces{
    interface IFirstInterface{
        void firstInterfaceMethod();
    }
    interface ISecondInterface{
        void secondInterfaceMethod();
    }
    class DemoClass : IFirstInterface, ISecondInterface{
        public void firstInterfaceMethod(){
            Console.WriteLine("Hello, from first interface method.");
        }
        public void secondInterfaceMethod(){
            Console.WriteLine("Hi, from second interface method.");
        }
    }
    class MainMethodMultiInterface{
        static void Main(string[] args){
            DemoClass dc = new DemoClass();
            dc.firstInterfaceMethod();
            dc.secondInterfaceMethod();
        }
    }
}