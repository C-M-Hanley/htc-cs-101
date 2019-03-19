using System;

namespace week07
{
    class Program
    {

//       public static void fizzBuzz(int number)
//       {
//           for(int num = 0; num < number; num++)
//           {
//           if (num % 5 == 0 && num % 3 == 0)
//           {
//           Console.WriteLine("FizzBuzz");
//           }
              
//           else if (num % 3 == 0)
//           {
//           Console.WriteLine("Fizz");
//           }
        
//          else if (num % 5 == 0)
//          {
//          Console.WriteLine("Buzz");
//          }

//          else
//          {
//          Console.WriteLine(num);
//          }
    
    
        
//         }

//           }
      

        static void Main(string[] args)
        { 
            Console.WriteLine("Enter a top number:");
             int num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter a bottom number:");
             int bnum = Convert.ToInt32(Console.ReadLine());

             numberGame(num, bnum);
       
        }
// }


        public static void numberGame(int tnum, int bnum)
        {
           
            int sum = 0;

            for (int i = bnum; i <= tnum; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        } 

    }
}
        