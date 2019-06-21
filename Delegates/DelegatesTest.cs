using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundumentals.Delegates
{
    public static class DelegateTest
    {
        public static void Run()
        {
            var c0 = new BaseClass();
            var c1 = new InheretedClass1();
            var c2 = new InheretedClass2();
            var list = new BaseClass[] { c0, c1, c2 };
            foreach (var c in list)
            {
                Console.WriteLine("Run BaseClass:");
                c.SomeMethod();
            }

            var c3 = new SeparateClass1();
            var c4 = new SeparateClass2();
            Console.WriteLine("Run StaticClass:");
            StaticClass.RunSomeMethod();

            Console.ReadLine();
        }
    }
}
