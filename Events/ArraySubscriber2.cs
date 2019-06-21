using System;

namespace CSharpFundumentals
{
    class ArraySubscriber2 : IDisposable
    {
        private readonly CustomArray _array;

        public ArraySubscriber2(CustomArray array)
        {
            _array = array;
            _array.ScanStart += OnScanStart;
            _array.ScanDone += OnScanDone;
            _array.IterateOdd += LogOdd;
        }

        public void Dispose()
        {
            _array.ScanStart -= OnScanStart;
            _array.ScanDone -= OnScanDone;
            _array.IterateOdd -= LogOdd;
        }

        private void LogOdd(object sender, OddNumberEventArgs args)
        {
            if (args.CurrentNumber == 3)
            {
                args.CancelRequested = true;
            }
            Console.WriteLine($"subscriber2 => odd number: {args.CurrentNumber}");
        }

        private static async void OnScanStart(object sender, EventArgs args)
        {
            Console.WriteLine("subscriber2 => array scan started! OnScanStart is sleeping..");
            try
            {
                await System.Threading.Tasks.Task.Run(() => DoWork());
            }
            catch (Exception e)
            {
                Console.WriteLine($"subscriber2 => error: {e.Message}");
            }
        }

        private static void DoWork()
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("subscriber2 => OnScanStart woke up!");
        }

        private static void OnScanDone(object sender, EventArgs args)
        {
            Console.WriteLine("subscriber2 => array scan is done!");
        }

        private static void OnIterateOdd(object sender, OddNumberEventArgs args)
        {
            Console.WriteLine($"subscriber2 => odd number: {args.CurrentNumber}");
        }
    }
}
