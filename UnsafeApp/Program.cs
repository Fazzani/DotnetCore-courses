using System;
using static System.Console;

namespace UnsafeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pointers.Example1();
            Pointers.Example2();
            ReadKey();
            
        }

        unsafe static void FastCopy(byte[] src, byte[] dst, int count)
        {
            Span<int> block = stackalloc int[3] { 1, 2, 3 };
        }
    }
}
