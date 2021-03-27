using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your very important interview!");
            Console.Write("What is your name ? ");
            string name = Console.ReadLine();
            Console.WriteLine(name + " how old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(name +" what is your favorite color?");
            string color = Console.ReadLine();

            Console.BackgroundColor =  (ConsoleColor) Enum.Parse(typeof(ConsoleColor), color);


            if(age >= 21)
            {
                Console.WriteLine("You want to come and crack open a cold one with us after work!");
            } else
            {
                Console.WriteLine("It will be a rootbeer for you then, young buck...");
            }






        }
    }
}
