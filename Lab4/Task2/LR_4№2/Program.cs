using System;
using System.Runtime.InteropServices;

namespace LR_4_2
{
    class Program
    {
        [DllImport("C:\\TestLib\\Debug\\MathLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Sum(int a, int b);
        [DllImport("C:\\TestLib\\Debug\\MathLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Difference(int a, int b);
        [DllImport("C:\\TestLib\\Debug\\MathLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern double Division(int a, int b);
        [DllImport("C:\\TestLib\\Debug\\MathLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern double Exponentiation(int a, int b);

        static void Main(string[] args)
        {
            int sum = Sum(3, 4);
            int dif = Difference(3, 4);
            double div = Division(3, 4);
            double pow = Exponentiation(3, 4);
            Console.WriteLine($" Actions with 3 and 4:\n Sum: {sum}\n Difference: {dif}\n Division:\n {div}" +
                $"\n Exponentation: {pow}");
        }
    }
}
