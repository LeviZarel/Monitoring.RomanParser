using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring
{
    public class Parser
    {
        private ConversionTable Table;
        public Parser()
        {
            Table = new ConversionTable();
        }
        public string GetItem(int value)
        {
            return Table.GetSymbolOf(value);
        }
    }
}