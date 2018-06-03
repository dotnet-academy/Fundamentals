using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class AbstractSample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Simple Inheritance");

            // code below does not work because BaseClass cannot be directly instantiated
            //BaseClass parent = new BaseClass();
            
            ChildA childA = new ChildA();
            childA.Method1();
            childA.Method2();

            Helpers.DisplaySectionEnd();
        }

        public abstract class BaseClass
        {
            public void Method1()
            {
                Console.WriteLine("Method1 - BaseClass");
            }

            public abstract void Method2();
        }

        public class ChildA : BaseClass
        {
            public override void Method2()
            {
                Console.WriteLine("Method2 - ChildA");
            }
        }
    }
}
