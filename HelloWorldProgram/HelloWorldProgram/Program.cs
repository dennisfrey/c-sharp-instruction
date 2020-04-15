using System;

namespace HelloWorldProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            String choice = "y";

            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("you entered  " + n4);
            if (n4 > 4)
            {
                Console.WriteLine(n4 + " is greater than 4");
            }
            else
            {
                Console.WriteLine(n4 + " is less than or equal to 4");
            }

            while (choice.Contains("y"))
            {
                Console.WriteLine("In the loop....");
                Console.WriteLine("Continue? ...");
                choice = Console.ReadLine();
            }

        }
    }
}
