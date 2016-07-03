using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Common.Formats
{
    public class QuoteFormatter : IFormatter
    {
        public string Format(int number)
        {
            return $"'{number}'";
        }
    }
}
