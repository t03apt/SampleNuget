namespace SampleNuget;

public class MyAwesomeService
{
    public static void WriteFibonacci(int len)
    {
        int a = 0, b = 1;
        Console.Write("{0} {1}", a, b);
        for (var i = 2; i < len; i++)
        {
            var c = a + b;
            Console.Write(" {0}", c);
            a = b;
            b = c;
        }
    }
}
