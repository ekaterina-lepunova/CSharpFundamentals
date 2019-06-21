using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundumentals.Delegates
{
    public class InheretedClass1: BaseClass
    {
        public override void SomeMethod()
        {
            Console.WriteLine(nameof(InheretedClass1));
        }
    }
}
