using System;

namespace SiddCode {
  class DataTypeSize {
    static void Main(string[] args) {
      Console.WriteLine(sizeof(bool) + " bytes");
      Console.WriteLine(sizeof(byte) + " bytes");
      Console.WriteLine(sizeof(sbyte) + " bytes");
      Console.WriteLine(sizeof(char) + " bytes");
      Console.WriteLine(sizeof(short) + " bytes");
      Console.WriteLine(sizeof(ushort) + " bytes");
      Console.WriteLine(sizeof(int) + " bytes");
      Console.WriteLine(sizeof(uint) + " bytes");
      Console.WriteLine(sizeof(float) + " bytes");
      Console.WriteLine(sizeof(long) + " bytes");
      Console.WriteLine(sizeof(ulong) + " bytes");
      Console.WriteLine(sizeof(double) + " bytes");
      Console.WriteLine(sizeof(decimal) + " bytes");
      
      Console.WriteLine("size of {0} is {1} bytes", typeof (bool), sizeof(bool));
      Console.WriteLine("size of {0} is {1} bytes", typeof (byte), sizeof(byte));
      Console.WriteLine("size of {0} is {1} bytes", typeof (char), sizeof(char));
      Console.WriteLine("size of {0} is {1} bytes", typeof (UInt32), sizeof(UInt32));
      Console.WriteLine("size of {0} is {1} bytes", typeof (ulong), sizeof(ulong));
      Console.WriteLine("size of {0} is {1} bytes", typeof (decimal), sizeof(decimal));

      Console.ReadLine();
    }
  }
}