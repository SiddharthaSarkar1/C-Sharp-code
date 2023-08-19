using System;
namespace SiddCodes{
    class TypeCastingMethods{
        static void Main(string[] args){
            int myInt = 10;
            double myDouble = 55.46;
            bool myBoolean = true;
            //Convert int to string
            Console.WriteLine(Convert.ToString(myInt));
            //Convert int to double
            Console.WriteLine(Convert.ToDouble(myInt));
            //Convert double to int
            Console.WriteLine(Convert.ToInt32(myDouble));
            //Convert boolean to string
            Console.WriteLine(Convert.ToString(myBoolean));
        }
    }
}