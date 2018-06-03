using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class InterfaceInheritanceSample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Interface Inheritance");

            {
                Console.WriteLine($"Type is class");
                Console.WriteLine();

                ChildA childA = new ChildA();
                childA.Method1();

                ChildB childB = new ChildB();
                childB.Method2();

                ChildAB childAB = new ChildAB();
                childAB.Method1();
                childAB.Method2();
            }

            {
                Console.WriteLine();
                Console.WriteLine($"Type is interface");
                Console.WriteLine();

                IInterfaceA childA = new ChildA();
                childA.Method1();

                IInterfaceB childB = new ChildB();
                childB.Method2();

                IInterfaceA childAB1 = new ChildAB();
                childAB1.Method1();
                // childAB.Method2(); cannot access Method2 because it is not defined in IInterfaceA

                IInterfaceB childAB2 = new ChildAB();
                // childAB2.Method1(); cannot access Method1 because it is not defined in IInterfaceB
                childAB2.Method2();
            }

            Helpers.DisplaySectionEnd();
        }

        public interface IInterfaceA
        {
            void Method1();
        }

        public interface IInterfaceB
        {
            void Method2();
        }

        public class ChildA : IInterfaceA
        {
            public void Method1()
            {
                Console.WriteLine("Method1 - ChildA");
            }
        }

        public class ChildB : IInterfaceB
        {
            public void Method2()
            {
                Console.WriteLine("Method2 - ChildB");
            }
        }

        public class ChildAB : IInterfaceA, IInterfaceB
        {
            public void Method1()
            {
                Console.WriteLine("Method1 - ChildAB");
            }

            public void Method2()
            {
                Console.WriteLine("Method2 - ChildAB");
            }
        }

    }
}
