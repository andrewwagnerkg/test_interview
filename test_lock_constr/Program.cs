using System;

namespace test_lock_constr
{
    static class Program
    {
        private static object _lockObj = new object();
        private static int lock_int = new int();
        static void Main(string[] args)
        {
            lock ((lock_int as object))
            {
                Console.WriteLine("Test lock");
            }
        }
    }
}