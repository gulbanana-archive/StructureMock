namespace Lib.Common
{
    public static class Printer
    {
        public static string Print(IFormatter f)
        {
            var text = f.Format(1);
            return $"Output: {text}";
        }
    }
}
