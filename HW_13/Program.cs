namespace HW_13
{
    public class Program
{
    public static void Show(bool result)
    {
        Console.WriteLine(result);
    }

    private static void Main()
    {
        var class1 = new Class1();
        var class2 = new Class2();

        Show(class2.Calc(class1.Multiply, 5, 8).Invoke(5));
    }
}
}