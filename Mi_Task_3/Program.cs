namespace Mi_Task_3;

public class Program
{
    public static void Main()
    {
        var q1 = new Quaternion(1, 2, 3, 4);
        var q2 = new Quaternion(2, 3, 4, 5);

        Console.WriteLine($"q1: {q1}");
        Console.WriteLine($"q2: {q2}");
        Console.WriteLine($"q1 + q2: {q1 + q2}");
        Console.WriteLine($"q1 * q2: {q1 * q2}");
        Console.WriteLine($"Norm of q1: {q1.Norm()}");
        Console.WriteLine($"Conjugate of q1: {q1.Conjugate()}");
    }
}