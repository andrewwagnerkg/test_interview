using System;

namespace test_lock_constr
{
    static class Program
    {
        private static object _lockObj = new object();
        private static int lock_int = new int();
        private static TestEnum enum_test;
        static void Main(string[] args)
        {
            lock ((lock_int as object))
            {
                Console.WriteLine("Test lock");
            }
            
            //result we can use value type in lock construction
            /*switch (enum_test)
            {
                case TestEnum.Test1:
                    Console.WriteLine(enum_test.ToString());
                    break;
                case TestEnum.Test2:
                    Console.WriteLine(enum_test.ToString());
                    break;
                case TestEnum.Test3:
                    Console.WriteLine(enum_test.ToString());
                    break;
                case TestEnum.Test4:
                    Console.WriteLine(enum_test.ToString());
                    break;
                case TestEnum.Test5:
                    Console.WriteLine(enum_test.ToString());
                    break;
                case TestEnum.Test6:
                    Console.WriteLine(enum_test.ToString());
                    break;
                case TestEnum.Test7:
                    Console.WriteLine(enum_test.ToString());
                    break;
            }*/
            // we can not use non sorted enum with default items
        }
    }

    enum TestEnum
    {
        Test1 = 1,
        Test2 = 2,
        Test3 = -3,
        Test4 = -2,
        Test5,
        Test6,
        Test7
    }
}