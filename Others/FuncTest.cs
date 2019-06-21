using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundumentals.Others
{
    public static class FuncTest
    {

        public static void Run()
        {
            Console.WriteLine("Running predicate:");
            var list = new int[] { 12,4,67,8,99 };

        }


        private static Predicate<int> Less10(int num)
        {
            return num < 10;
        }
    }
}
