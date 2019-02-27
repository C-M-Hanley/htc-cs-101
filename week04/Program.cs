using System;

namespace Week04
{
    class Program
    {
        static void Main(string[] args)
        {
           

          {
              bool Snowing = true;
              bool HaveCarrot = true;
              int temp = 40;
              string clothes = "Outfit";
              string name = "Kevin";

              if (Snowing && temp <= 40 && (name != "Bob" || HaveCarrot)) {
                  Console.WriteLine("I am a snow man!");
              }

              if(true || false) {
                  Console.WriteLine("I!");
              }

              else{
                  Console.WriteLine("o!");
              }

             

          }
 
string day = Console.ReadLine();
          if (day == "mon" || day == "tue"){
               Console.WriteLine("yay!");
          }

        }
    }
}
