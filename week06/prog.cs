using System;

namespace week06
{
    class Pro
    {
       

        public static void math()
        {
             Console.WriteLine("Choose a number");
      int num = Convert.ToInt32(Console.ReadLine());
            
                int x = 0;
                
                while(x < num) {
                    x++; 
                    if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
                }
        }

  }
}