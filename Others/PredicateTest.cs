using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundumentals.Others
{
    public static class PredicateTest
    {
        public static void Run()
        {
            var list = new int[] { 12, 4, 6, 1, 99 };
            Console.WriteLine($"Soure array: {string.Join(", ", list)}");
            // predicate may be defined clearly
            //Predicate<int> pr1 = Less10;
            var less10 = list.Filter(Less10);
            Console.WriteLine($"Less 10 array: {string.Join(", ", less10)}");
            var greater5 = list.Filter(Greater5);
            Console.WriteLine($"Greater 5 array: {string.Join(", ", greater5)}");
            Console.ReadLine();
        }

        private static int[] Filter(this int[] source, Predicate<int> filterFun)
        {
            var result = new List<int>();
            foreach (var item in source)
            {
                if (filterFun(item))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }


        private static bool Less10(int num)
        {
            return num < 10;
        }

        private static bool Greater5(int num)
        {
            return num > 5;
        }
    }
}
