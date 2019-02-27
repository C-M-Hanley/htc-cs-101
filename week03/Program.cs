using System;

namespace week03
{
    class Program
    {
        static void Main2(string[] args)
        {
     
      Console.WriteLine("Guess a number between 1 and 10.");
      int num = Convert.ToInt32(Console.ReadLine());
      
      
      if (num > 4){
          Console.WriteLine("Too High!");
      }

      else if (num < 4){
          Console.WriteLine("Too Low!");
      }

       else {
          Console.WriteLine("Just Right!");
      }

        }
    }
}
