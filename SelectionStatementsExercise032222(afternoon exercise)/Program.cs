using System;

namespace SelectionStatementsExercise032222_afternoon_exercise_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise # 1

            //var r = new Random();
            //var favNumber = r.Next(1, 10);

            //Console.WriteLine("Pick a number from 1 - 1000");
            //var userInput = int.Parse(Console.ReadLine());

            //if (userInput < favNumber)
            //{
            //    Console.WriteLine($"{userInput} is too low");
            //}
            //else if (userInput > favNumber)
            //{
            //    Console.WriteLine($"{userInput} is too high");
            //}
            //else
            //{
            //    Console.WriteLine("You got it!!!");
            //}


            //Exercise # 2

            Console.WriteLine("\nWhat is your favorite school subject?");

            var subject = Console.ReadLine(); //Evaluate to a string

            switch (subject.ToLower())
            {
                case "c#":
                case "programming":
                    Console.WriteLine("C# is a very intense subject.");
                    break;
                case "chemistry":
                case "science":
                    Console.WriteLine("Chemistry is a tough subject.");
                    break;
                case "calculus":
                    Console.WriteLine("Calculus is a very difficult subject.");
                    break;
                case "english":
                    Console.WriteLine("English requires too much writing with essays and reports.");
                    break;
                case "history":
                    Console.WriteLine("History is interesting.");
                    break;
                default:
                    Console.WriteLine($"Yeah, I know what you mean! {subject} sounds difficult but cool too.");
                    break;


            }



        }
    }
}














