using Lib.Common.Core;

namespace Lib.Common
{
    public static class Printer
    {
        public static string Print(IFormatter f)
        {
            var c = new Calculator();
            var text = f.Format(c.CalculateNumber());
            return $"Output: {text}";
        }
    }
}
