using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class TypesSample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Types");

            Declarations();

            int valueType = 5;
            Console.WriteLine($"Value type before calling method: {valueType}");
            ChangeValueOfValueType(5);
            Console.WriteLine($"Value type after calling method: {valueType}");

            int[] referenceType = new int[] { 5 };
            Console.WriteLine($"Reference type before calling method: {referenceType[0]}");
            ChangeValueOfReferenceType(referenceType);
            Console.WriteLine($"Reference type after calling method: {referenceType[0]}");

            Helpers.DisplaySectionEnd();
        }

        public static void Declarations()
        {
            // this method doesn't really do anything, just shows some types declarations

            // value types
            bool booleanValue = true;
            byte byteValue = 255;
            short shortValue = 32767;
            int intValue = 2147483647;
            long longValue = 9223372036854775807;
            decimal decimalValue = 123.5m;
            double doubleValue = 123;
            char charValue = 'a';
            Day enumValue = Day.Mon;

            //reference types
            string stringValue = "hello world";
                string[] stringArray = new string[] { "abc", "def", "efg" };
                int[] intArray = new int[] { 1, 2, 3 };
                MyClass instance = new MyClass();
        }

        public static void ChangeValueOfValueType(int input)
        {
            input++;
        }

        public static void ChangeValueOfReferenceType(int[] input)
        {
            input[0]++;
        }

        class MyClass
        {

        }

        enum Day { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
    }
}

