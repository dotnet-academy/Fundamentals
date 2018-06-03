using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class TypeCastingSample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Type Casting");

            {
                byte byteValue = 200;
                int intValue = byteValue; // intValue = 200 (implicit conversion)
                Console.WriteLine($"Implicit conversion of byte to int");
                Console.WriteLine($"byte value = {byteValue} -> int value = {intValue}");
                Console.WriteLine();
            }

            {
                int intValue = 500;
                //byte byteValue = intValue; // does not compile, cannot implicitly convert type int to byte
                byte byteValue = (byte)intValue; // works, but byteValue is not the same as intValue, precision loss (explicit conversion)
                Console.WriteLine($"Implicit conversion of int to byte (precision loss)");
                Console.WriteLine($"int value = {intValue} -> byte value = {byteValue}");
                Console.WriteLine();

                intValue = 200;
                byteValue = (byte)intValue; // works, no precision loss because value of int type can fit inside byte type (explicit conversion)
                Console.WriteLine($"Explicit conversion of int to byte (no precision loss)");
                Console.WriteLine($"int value = {intValue} -> byte value = {byteValue}");
                Console.WriteLine();
            }

            Helpers.DisplaySectionEnd();
        }

        

    }
}

