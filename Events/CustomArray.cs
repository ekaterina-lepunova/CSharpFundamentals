using System;

namespace CSharpFundumentals
{
    class CustomArray
    {
        private int[] numbers;
        public event EventHandler<OddNumberEventArgs> IterateOdd;
        public event EventHandler<EventArgs> ScanDone;
        public event EventHandler<EventArgs> ScanStart;

        public CustomArray(int[] array)
        {
            numbers = array;
        }

        public void ScanArray()
        {
            ScanStart?.Invoke(this, EventArgs.Empty);
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    var args = new OddNumberEventArgs(numbers[i]);
                    IterateOdd?.Invoke(this, args);
                    if (args.CancelRequested)
                    {
                        break;
                    }
                }
            }
            ScanDone?.Invoke(this, EventArgs.Empty);
        }
    }
}
