namespace TestProject1;

public static class ConsoleOutput
{
    private static readonly Queue<string> Output = new();

    public static string GetOutput()
    {
        return string.Concat(Output);
    }

    public static void Clear()
    {
        Output.Clear();
    }

    public static void WriteLine(string value)
    {
        Output.Enqueue(value + "\n");
    }
}