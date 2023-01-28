﻿/*Author: Vanessa Garcia
 * Course: Comp - 003A - L01
 * Purpose: Assignment Two Programming Basics
*/


namespace ClearConsole

{
    class Program
    {


        static void Main(string[] args)
        {
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

        }
    }
}









