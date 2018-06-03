using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public class SealedSample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Sealed");

            BaseClass parent = new BaseClass();
            parent.Method1();
            parent.Method2();

            ChildA childA = new ChildA();
            childA.Method1();
            childA.Method2();

            ChildB childB = new ChildB();
            childB.Method1();
            childB.Method2(); // ChildA.Method2() will be shown since it cannot be further overriden

            Helpers.DisplaySectionEnd();
        }

        public class BaseClass
        {
            public virtual void Method1()
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
            public override void Method1()
            {
                Console.WriteLine("Method1 - ChildA");
            }

            public sealed override void Method2()
            {
                Console.WriteLine("Method2 - ChildA");
            }
        }

        public class ChildB : ChildA
        {
            public override void Method1()
            {
                Console.WriteLine("Method1 - ChildB");
            }

            // cannot use code below because ChildA.Method2 is sealed
            //public override void Method2()
            //{
            //    Console.WriteLine("Method2 - ChildB");
            //}
        }
    }
}
