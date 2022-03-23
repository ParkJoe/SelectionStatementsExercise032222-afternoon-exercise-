using System;

namespace SelectionStatementsExercise032222_afternoon_exercise_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise # 1

            Console.WriteLine("Welcome to the number guessing game!!");
            Console.WriteLine("See if you can guess the correct number");
            Console.WriteLine("What is the upper limit for the range of the number");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, 10);

            Console.WriteLine("Input your guess:");

            var guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Your guess is too high, sorry!");
            }
            else if (guess < number)
            {
                Console.WriteLine("Your guess is too low, sorry!");
            }
            else
            {
                Console.Write("Correct, you got it!!!");

            //Exercise # 2

                Console.WriteLine("\nWhat is your favorite school subject?");

                var subject = Console.ReadLine(); //Evaluate to a string

                switch (subject.ToLower())
                {
                    case "c#":
                        Console.WriteLine("C# is a very intense subject.");
                        break;
                    case "chemistry":
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
}


       





