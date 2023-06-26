using System;

namespace SampleNuget;

public class MyAwesomeService
{
    public static void Fibonacci(int len, Action<int> func)
    {
        int a = 0, b = 1;
        func(a);
        func(b);
        for (var i = 2; i < len; i++)
        {
            var c = a + b;
            func(c);
            a = b;
            b = c;
        }
    }
}
