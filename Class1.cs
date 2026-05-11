using System.Diagnostics;

namespace ClassLibrary
{
    public class Class1
    {
        public Class1()
        {
            Trace.Listeners.Add(new TextWriterTraceListener("Log.txt"));
            Trace.AutoFlush = true;
        }
        public double Addition(double a, double b)
        {
            Trace.WriteLine($"{a} + {b} = {a+b}");
            return a + b;
        }
        public double Substruct(double a, double b) => a - b;
        public double Сomposition(double a, double b) => a * b;
        public double Power(double a, double b) => Math.Pow(a, b);
    }
}
