using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
  class FileProgram
  {
    static void Main(string[] args)
    {
        // Create a text string
      string writeText = "Hello World!";  
      // Create a file and write the contents of writeText to it
      File.WriteAllText("filename.txt", writeText);  

    // Read the contents of the file
      string readText = File.ReadAllText("filename.txt"); 
      // Output the content
      Console.WriteLine(readText); 
    }
  }
}