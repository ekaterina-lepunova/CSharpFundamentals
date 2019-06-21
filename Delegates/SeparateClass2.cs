using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundumentals.Delegates
{
    public class SeparateClass2 : IDisposable
    {
        public SeparateClass2()
        {
            StaticClass.SomeMethod += SomeMethod;
        }

        public void Dispose()
        {
            StaticClass.SomeMethod -= SomeMethod;
        }

        public void SomeMethod(string msg)
        {
            Console.WriteLine($"{nameof(SeparateClass2)}:{msg}");
        }
    }
}
