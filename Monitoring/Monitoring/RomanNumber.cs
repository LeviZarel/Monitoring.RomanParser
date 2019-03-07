using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring
{
    public class RomanNumber
    {
        public int Value { get; private set; }
        public string Symbol { get; private set; }
        public RomanNumber(int value, string symbol)
        {
            Value = value;
            Symbol = symbol;
        }
    }
}