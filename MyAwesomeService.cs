namespace SampleNuget;

public class MyAwesomeService
{
    public static IEnumerable<int> WriteFibonacci(int len)
    {
        int a = 0, b = 1;
        yield return a;
        yield return b;
        for (var i = 2; i < len; i++)
        {
            var c = a + b;
            yield return c;
            a = b;
            b = c;
        }
    }
}
