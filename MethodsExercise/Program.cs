using System;

namespace MethodsExercise
{
    public class Program
    {

        public static void ShortStory()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What did you want to be when you grew up?");
            string childhoodDream = Console.ReadLine();
            Console.WriteLine("What is your biggest weakness?");
            string biggestWeakness = Console.ReadLine();
            Console.WriteLine("What is your greatest strength?");
            string greatestStrength = Console.ReadLine();
            Console.WriteLine($"Have you ever heard the tale of {name}? This person was once an aspiring {childhoodDream}. That is until {biggestWeakness} got in the way. But that didn't stop {name} from trying even harder. Their {greatestStrength} helped them perservere and achieve their dream of becoming a {childhoodDream}.");
        }

        public static int Add(params int[] num)
        {
            int total = 0;

            for(int i = 0; i<num.Length; i++)
            {
                total += num[i];
            }
            return total;
        }

        public static int Subtract(params int[] num)
        {
            int total = num[0];
            // I'm assuming the first number you enter is the number you want to subtract from, like you would in a calculator app. 

            for (int i = 1; i < num.Length; i++)
            {
                total -= num[i];
            }
            return total;
        }

        public static int Multiply(params int[] num)
        {
            int total = num[0];
            for(int i = 1; i<num.Length; i++)
            {
                total *= num[i];
            }
            return total;
        }
        public static int Divide(params int[] num)
        {
            int total = num[0];
            // I'm assuming the first number you enter is the number you want to divide from, like you would in a calculator app. 

            for (int i = 1; i < num.Length; i++)
            {
                total /= num[i];
            }
            return total;
        }

        static void Main(string[] args)
        {
            ShortStory();
            Console.WriteLine(Add(1, 2, 3, 4));
            Console.WriteLine(Subtract(10, 2, 3, 4));
            Console.WriteLine(Multiply(2, 3, 4, 5));
            Console.WriteLine(Divide(20, 2, 2));
        }
    }
}
