using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class ClassSample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Class");

            MyClass instance1 = new MyClass();
            MyClass instance2 = new MyClass(10);


            Helpers.DisplaySectionEnd();
        }

        public class MyClass
        {
            // static constructor
            static MyClass()
            {
                _myStaticField = 500;
            }

            // default constructor
            public MyClass()
            {
                MyField1 = 50;
            }

            // constructor with parameter (constructor overloading)
            public MyClass(int initValue)
            {
                MyField1 = initValue;
            }

            public const string MyConstant = "This can never change";
            public int MyField1;
            public int MyField2 = 100;

            private static int _myStaticField;
            private int _myProperty2;

            // autoimplemented property
            public int MyProperty1 { get; set; }


            public int MyProperty2
            {
                // accessors with custom logic
                get
                {
                    return _myProperty2;
                }

                set
                {
                    _myProperty2 = value;
                }
            }

            // method with two parameters
            public long Add(int a, int b)
            {
                return a + b;
            }

            // method with three parameters (method overloading)
            public long Add(int a, int b, int c)
            {
                return a + b + c;
            }
        }

    }
}

