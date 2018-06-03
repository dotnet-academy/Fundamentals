using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class ArgumentsSample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Named arguments");

            MyClass instance = new MyClass();

            {
                Console.WriteLine();
                Console.WriteLine($"Named Arguments");
                Console.WriteLine();

                string fullName;

                // when using values only then all arguments must be at the correct position
                fullName = instance.SayMyName("Mr", "John", "Smith");
                Console.WriteLine($"Positioned arguments: {fullName}");

                // when using named arguments position is not important
                fullName = instance.SayMyName(title: "Mr", lastName: "Smith", firstName: "John");
                Console.WriteLine($"Named arguments: {fullName}");

                // when using named arguments and just values then the value arguments must be on the
                // correct position, the named arguments can be anywhere else
                fullName = instance.SayMyName(title: "Mr", "John", lastName: "Smith");
                Console.WriteLine($"Mixed position arguments: {fullName}");

                // error because arguments are not in correct position
                //fullName = instance.SayMyName(title: "Mr", lastName: "Smith", "John");
            }

            {
                Console.WriteLine();
                Console.WriteLine($"Optional Arguments");
                Console.WriteLine();

                string fullName;

                // omitting the optional parameter results to getting its predefined value 
                fullName = instance.SayMyNameOptional("John", "Smith");
                Console.WriteLine($"Optional arguments: {fullName}");

                // when providing a value for the optional parameter that value is then used
                fullName = instance.SayMyNameOptional("Mary", "Poppins", "Miss");
                Console.WriteLine($"Optional arguments: {fullName}");
            }

            Helpers.DisplaySectionEnd();
        }

        public class MyClass
        {
            public string SayMyName(string title, string firstName, string lastName)
            {
                return $"{title} {firstName} {lastName}";
            }

            public string SayMyNameOptional(string firstName, string lastName, string title = "Mr")
            {
                return $"{title} {firstName} {lastName}";
            }
        }

    }
}

