using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundumentals.Delegates
{
    public class SeparateClass1 : IDisposable
    {
        public SeparateClass1()
        {
            StaticClass.SomeMethod += SomeMethod;
        }

        public void Dispose()
        {
            StaticClass.SomeMethod -= SomeMethod;
        }

        public void SomeMethod(string msg)
        {
            Console.WriteLine($"{nameof(SeparateClass1)}:{msg}");
        }
    }
}
