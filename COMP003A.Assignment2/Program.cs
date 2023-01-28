/*Author: Vanessa Garcia
 * Course: Comp - 003A - L01
 * Purpose: Assignment Two Programming Basics
*/


namespace ClearConsole

{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Console Section");
            Console.WriteLine("************************************************************************");



            Console.WriteLine("*************************************************************************");
            Console.WriteLine("String Section");
            Console.WriteLine("*************************************************************************");
            string firstName = "Vanessa";
            Console.WriteLine($"Enter First Name: {firstName}");
            string middleName = "Elizabeth";
            Console.WriteLine($"Enter Middle Name: {middleName}");
            string lastName = "Garcia";
            Console.WriteLine($"Enter Last Name: {lastName}");
            string inputAge = "40";
            Console.WriteLine($"Enter Age in 2023: {inputAge}");
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("************************************************************************");
            int x = 30;
            Console.WriteLine("Enter an Integer For Integer1: 30");
            int y = 7;
            Console.WriteLine("Enter an Integer For Integer2: 7");
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Circle Area and Circumference Calculator");
            Console.WriteLine("************************************************************************");
            Console.Write("Enter Radius: ");
            double Radius = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radius * Radius;



        }
    }
}









