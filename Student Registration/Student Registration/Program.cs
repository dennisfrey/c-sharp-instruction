using System;

namespace Student_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form");
            Console.WriteLine();

            String firstName = "";
            String lastName = "";
            int year = 0;

            Console.WriteLine("Enter first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter year of birth: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Welcome " + firstName + " " + lastName + "!" );
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + firstName + "*" + year);
        }
    }
}
