using System;
using System.Security.Cryptography.X509Certificates;

namespace TriviaProject
{
    class Program
    {
        static void Main(string[] args)
        {
           //Welcome Message
            Console.WriteLine("Welcome to Trivia TrueCoders  Project");
            Console.WriteLine("Lets see What Do you know about music");
           
           // Question # 1
            Console.WriteLine("Who is considered the King of Pop of all the times ");
            Console.WriteLine(" a - Michael Jackson ");
            Console.WriteLine(" b - Axl Rose ");
            Console.WriteLine(" c - The Weekend ");
            Console.WriteLine(" d - Steven Taylor");
            Console.WriteLine(" Your answer is ?");

            char answerOne = char.Parse(Console.ReadLine());
            
            // Checker Answer Question 1 Method 
            CheckerOne(answerOne);

            // Question # 2
            Console.WriteLine("What is the most British famous band ");
            Console.WriteLine(" a - The Police ");
            Console.WriteLine(" b - U2 ");
            Console.WriteLine(" c - Queen ");
            Console.WriteLine(" d - AC/DC");
            Console.WriteLine(" Your answer is ?");

            char answerTwo = char.Parse(Console.ReadLine());

            // Checker Answer Question 2 Method 
            CheckerTwo(answerTwo);

        }

        public static void CheckerOne(char answerOne)
        {
            if (answerOne == 'a')
            {
                Console.WriteLine("You are correct!");
                
                
            }
            else
            {
                Console.WriteLine("You are wrong!");
            }
        }

        public static void CheckerTwo(char answerTwo)
        {
            if (answerTwo == 'c')
            {
                Console.WriteLine("You are correct!");


            }
            else
            {
                Console.WriteLine("You are wrong!");
            }
        }
    }
}
