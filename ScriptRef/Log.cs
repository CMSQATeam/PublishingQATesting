using System.Diagnostics;

namespace DiffPlex
{
    public static class Log
    {
        [Conditional("LOG")]
        public static void WriteLine(string format, params object[] args)
        {
            Debug.WriteLine(string.Format(format, args));
        }

        [Conditional("LOG")]
        public static void Write(string format, params object[] args)
        {
            // not implemented
        }
        
         enum TestEnum
    {
        Hyderabad = 5,
        Banglore = 25
    }

        public delegate int TestDelegate(string s);

        public delegate void CalculateSquare(double number);
    }
}
