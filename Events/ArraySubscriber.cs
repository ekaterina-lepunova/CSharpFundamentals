using System;

namespace CSharpFundumentals
{
    class ArraySubscriber : IDisposable
    {
        private readonly CustomArray _array;
        private readonly EventHandler<OddNumberEventArgs> OnIterateOdd;

        public ArraySubscriber(CustomArray array)
        {
            _array = array;
            OnIterateOdd = LogOdd;
            _array.IterateOdd += OnIterateOdd;
        }

        public void Dispose()
        {
            _array.IterateOdd -= OnIterateOdd;
        }

        private void LogOdd(object sender, OddNumberEventArgs args)
        {
            if (args.CurrentNumber == 5)
            {
                args.CancelRequested = true;
            }
            Console.WriteLine($"subscriber1 => odd number: {args.CurrentNumber}");
        }
    }
}
