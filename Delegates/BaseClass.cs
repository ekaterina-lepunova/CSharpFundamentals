using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundumentals.Delegates
{
    public class BaseClass
    {
        public virtual void SomeMethod()
        {
            Console.WriteLine(nameof(BaseClass));
        }
    }
}
