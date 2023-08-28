using System.Net.NetworkInformation;
using System.Security.Authentication;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name traveller?");
            string username = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is the name of your pet companion?");
            string userpetname = Console.ReadLine();

            Console.WriteLine("What color is that pet companion?");
            string userpetcolor = Console.ReadLine();

            Console.WriteLine($"There once was a man named {username}, he was {age} years old.");
            Console.WriteLine($"He had a {userpetcolor} pet named {userpetname}");
            Console.WriteLine($"{username} fought alongside {userpetname} as they shared their proud age of {age} in common!");
            Console.WriteLine($"Despite their age they both fought against every thief, monster,and enemy while defeating them with ease!");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2, 2, 3, 5, 7);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");
        }

       public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }

public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
