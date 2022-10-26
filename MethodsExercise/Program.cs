using System;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {


        static void Main(string[] args)


        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}.He wanted to go the the fair to see his {favoriteBand}.");
            Console.WriteLine($"He had a good time there he bought a shirt in his {favoriteColor}, and won stuffed toy of his {favoriteAnimal}.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());


        }

        public static int Sum(int num1, int num2)
        {

            //int sum = num1 + num2;
            //return sum

            return num1 + num2;

        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }


    }

}
