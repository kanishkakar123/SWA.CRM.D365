using System;

namespace TestConsoleApp
{
    internal class Program
    {
        enum TestEnum { value1, value2 }
        static void Main(string[] args)
        {
            Console.WriteLine(nameof(TestEnum.value1));
            Console.ReadLine();
        }
    }
}
