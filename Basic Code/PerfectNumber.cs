using System;
//Perfect Number is 6
//1+2+3 = 6
//1,2,3 and 6 divides 6
namespace SiddCodes{
    class PerfectNumber{
        static void Main(string[] args){
            int num, rem, sum, i;
            sum = 0;
            Console.WriteLine("Enter anumber : ");
            string numStr = Console.ReadLine();
            num = Convert.ToInt32(numStr);
            for(i=1;i<=num-1;i++){
                rem = num % i;
                if(rem == 0){
                    sum = sum+i;
                }
            }
            if(sum == num){
                Console.WriteLine("Perfect Number");
            }else{
                Console.WriteLine("Not a Perfect Number");
            }
        }
    }
}