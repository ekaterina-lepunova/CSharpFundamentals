using System;

namespace CSharpFundumentals.Events
{
    public static class EventTest
    {
        public static void Run()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numbers = new CustomArray(arr);
            new ArraySubscriber(numbers);
            new ArraySubscriber2(numbers);

            numbers.ScanArray();

            Console.ReadLine();
        }
    }
}
