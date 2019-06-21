using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundumentals
{
    class OddNumberEventArgs : EventArgs
    {
        public int CurrentNumber { get; }
        public bool CancelRequested { get; set; }

        public OddNumberEventArgs(int number)
        {
            CurrentNumber = number;
        }
    }
}
