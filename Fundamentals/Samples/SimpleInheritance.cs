using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class SimpleInheritance
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Simple Inheritance");

            BaseClass parent = new BaseClass();
            parent.Method1();
            parent.Method2();

            ChildA childA = new ChildA();
            childA.Method1();
            childA.Method2();
            childA.Method3();

            ChildB childB = new ChildB();
            childB.Method1(); //method hiding
            childB.Method2(); //method override

            BaseClass parent2 = (BaseClass)childB;
            parent2.Method1(); // calling BaseClass method
            parent2.Method2(); // derived method will run since it overrides BaseClass

            Helpers.DisplaySectionEnd();
        }
    }

    public class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1 - BaseClass");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Method2 - BaseClass");
        }
    }

    public class ChildA : BaseClass
    {
        // inherits BaseClass.Method1()

        // inherits BaseClass.Method2()

        // extends functionality by adding Method3()
        public void Method3()
        {
            Console.WriteLine("Method3 - ChildA");
        }
    }

    public class ChildB : BaseClass
    {
        // hides BaseClass.Method1() with new implementation
        public new void Method1()
        {
            Console.WriteLine("Method1 - ChildB");
        }

        // overrides BaseClass.Method2() with another implementation
        public override void Method2()
        {
            Console.WriteLine("Method2 - ChildB");
        }
    }
}

