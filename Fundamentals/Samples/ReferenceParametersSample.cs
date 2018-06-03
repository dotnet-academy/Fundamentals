using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    class ReferenceParametersSample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Reference Types");

            int refArg = 100;
            RefMethod(ref refArg);
            Console.WriteLine(refArg);

            // int outArg; // can be used as well
            OutMethod(out int outArg);
            Console.WriteLine(outArg);

            int inArg = 300;
            InMethod(in inArg);
            Console.WriteLine(inArg);

            Helpers.DisplaySectionEnd();
        }

        public static void RefMethod(ref int input)
        {
            input++;
        }

        public static void OutMethod(out int input)
        {
            input = 200;
        }

        public static void InMethod(in int input)
        {
            // input = 1000; // cannot assign value, it's readonly
            var newValue = input;
        }
    }
}
