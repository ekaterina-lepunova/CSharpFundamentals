using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundumentals.Delegates
{
    public static class StaticClass
    {
        public static Action<string> SomeMethod;

        public static void RunSomeMethod()
        {
            SomeMethod?.Invoke(nameof(StaticClass));
        }
    }
}
