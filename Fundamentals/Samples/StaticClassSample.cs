using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class StaticClassSample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Static Class");

            // calling static methods
            Console.WriteLine(MyClass.Add(5, 10));
            Console.WriteLine(MyClass.Add(5, 10, 15));

            // calling extension methods
            string myString = "just a string";
            Console.WriteLine(myString.MyExtensionMethod());
            Console.WriteLine(myString.MyExtensionMethod("some more text"));

            Helpers.DisplaySectionEnd();
        }
    }

    public static class MyClass
    {
        // static constructor
        static MyClass()
        {
            _myStaticField = 500;
        }

        public const string MyConstant = "This can never change";
        private static int _myStaticField;

        // static method with two parameters
        public static long Add(int a, int b)
        {
            return a + b;
        }

        // static method with three parameters (method overloading)
        public static long Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // extension method without parameters
        public static string MyExtensionMethod(this string input)
        {
            return $"{input} - edit from extension method";
        }

        // extension method with one parameter
        public static string MyExtensionMethod(this string input, string text)
        {
            return $"{input} - {text}";
        }

    }
}

