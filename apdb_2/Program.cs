public class Program
{
    public static int Add(int a, int b) => a + b;
    public static int Sub(int a, int b) => a - b;

    public int MaxValues(int[] values)
    {
        return values.Max(); 
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(Add(1,2));
        Console.WriteLine(Sub(1,2));
    }
}