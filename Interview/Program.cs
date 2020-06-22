using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your very important interview!");
            string name = Console.ReadLine();
            Console.WriteLine(name + " how old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(name +" what is your favorite color?");
            string color = Console.ReadLine();

           // Console.BackgroundColor = color;

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
