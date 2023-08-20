using System;
namespace MyApp{
    class Person{
        private string name;
        public string Name
            {
            get{
                return name;
            }
            set{
                name = value;
            }
        }
    }
    class MyProgram{
        static void Main(string[] args){
            Person p = new Person();
            p.Name = "Siddhartha";
            Console.WriteLine(p.Name);
        }
    }
}