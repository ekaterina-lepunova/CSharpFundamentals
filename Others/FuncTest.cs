using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundumentals.Others
{
    public static class FuncTest
    {

        public static void Run()
        {
            var list = new int[] { 12, 4, 6, 1, 99 };
            Console.WriteLine($"Soure array: {string.Join(", ", list)}");
            // func may be defined clearly
            //Func<int, string, string> f = AddSuffix;
            var withSuffix = list.Stringify(AddSuffix, "kg");
            Console.WriteLine($"With Suffix array: {withSuffix}");
            var addPrefix = list.Stringify(AddPrefix, "i");
            Console.WriteLine($"With Prefix array: {addPrefix}");
            Console.ReadLine();
        }


        private static string Stringify(this int[] source, Func<int, string, string> fun, string funParam)
        {
            var result = new StringBuilder();
            foreach (var item in source)
            {
                result.Append(fun(item, funParam));
                result.Append(", ");
            }
            result.Remove(result.Length - 2, 2);
            return result.ToString();
        }

        private static string AddSuffix(int num, string suffix)
        {
            return string.Concat(num.ToString(), suffix);
        }

        private static string AddPrefix(int num, string prefix)
        {
            return string.Concat(prefix, num.ToString());
        }
    }
}
