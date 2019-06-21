using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundumentals.Delegates
{

    public class InheretedClass2 : BaseClass
    {
        public override void SomeMethod()
        {
            Console.WriteLine(nameof(InheretedClass2));
        }
    }
}
