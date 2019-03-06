using System;

namespace week05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the first number?");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the second number?");
            int secNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What opperation do you want to use?");
            string opperation = Console.ReadLine();

            if(opperation == "+"){
              Console.WriteLine(AddNumbers(firstNum, secNum));
            }

            else if (opperation == "-"){
            int difference = SubNumbers(firstNum, secNum);
            Console.WriteLine(difference);
        }

else if (opperation == "*"){
            int difference = MultNumbers(firstNum, secNum);
            Console.WriteLine(difference);
        }

        else if (opperation == "/"){
            int difference = DeviNumbers(firstNum, secNum);
            Console.WriteLine(difference);
        }

            else{
                Console.WriteLine("Invalid opperation:(");
            }
    
        }
        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int SubNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int MultNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

         public static int DeviNumbers(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
