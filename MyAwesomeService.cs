using System;

namespace SampleNuget;

public class MyAwesomeService
{
    public static void Fibonacci(int len, Action<int> action)
    {
        int a = 0, b = 1;
        action(a);
        action(b);
        for (var i = 2; i < len; i++)
        {
            var c = a + b;
            action(c);
            a = b;
            b = c;
        }
    }
}
