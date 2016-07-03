using Lib.Common.Core;
using System.Diagnostics;

namespace Lib.Common
{
    public static class Printer
    {
        public static void Print(IFormatter f)
        {
            var c = new Calculator();
            var text = f.Format(c.CalculateNumber());
            Debug.WriteLine($"Output: {text}");
        }
    }
}
