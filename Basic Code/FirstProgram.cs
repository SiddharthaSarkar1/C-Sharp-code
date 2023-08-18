using System;

public class FirstProgram
{
    public static void Main(string[] args)
    {
        //I am starting C# journey
        Console.WriteLine ("Hello World");
        COnsole.WriteLine("Sidd learning C#");
        Console.WriteLine("Enter first numbers : ");
        string num1 = Console.ReadLine();
        int num1 = Convert.ToInt32(num1);
        Console.WriteLine("Enter second numbers : ");
        string num2 = Console.ReadLine();
        int num2 = Convert.ToInt32(num2);
        Console.WriteLine(num1 + num2); 
        // Console.WriteLine(num1);
    }
}